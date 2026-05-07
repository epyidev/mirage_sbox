#!/usr/bin/env node
/**
 * @author Epyi
 *
 * Generates Docs/Sbox/ from the raw s&box documentation drop in Downloaded/.
 *
 * Inputs (relative to repo root):
 *   - Downloaded/Documentation/             Markdown guides + images mirrored from
 *                                           Facepunch/sbox-docs (CC BY 4.0).
 *   - Downloaded/api_reference.json         Auto-generated API reference dump
 *                                           with every public type, member and
 *                                           XML doc summary.
 *
 * Output:
 *   - Docs/Sbox/guides/                     Verbatim markdown + toc.yml from the
 *                                           upstream guides, with image and video
 *                                           assets dropped (text-only).
 *   - Docs/Sbox/api/INDEX.md                Alphabetical index of every type.
 *   - Docs/Sbox/api/INDEX_BY_NAMESPACE.md   Same index grouped by namespace.
 *   - Docs/Sbox/api/namespaces/<slug>/      One markdown file per type, plus an
 *                                           _index.md for the namespace.
 *
 * The script is idempotent: it wipes Docs/Sbox/guides and Docs/Sbox/api before
 * writing. SKILL.md, README.md and reference/ are left untouched so hand-edits
 * survive a regeneration.
 */

import fs from 'node:fs';
import path from 'node:path';
import { fileURLToPath } from 'node:url';

const here = path.dirname(fileURLToPath(import.meta.url));
const REPO_ROOT = path.resolve(here, '..', '..');
const SRC_GUIDES = path.join(REPO_ROOT, 'Downloaded', 'Documentation');
const SRC_API = path.join(REPO_ROOT, 'Downloaded', 'api_reference.json');
const OUT_ROOT = path.join(REPO_ROOT, 'Docs', 'Sbox');
const OUT_GUIDES = path.join(OUT_ROOT, 'guides');
const OUT_API = path.join(OUT_ROOT, 'api');

const TEXT_EXTENSIONS = new Set(['.md', '.yml', '.yaml']);
const SKIP_DIR_NAMES = new Set(['images', 'image', 'video', 'videos']);

function rmrf(target) {
	if (fs.existsSync(target)) fs.rmSync(target, { recursive: true, force: true });
}

function ensureDir(p) {
	fs.mkdirSync(p, { recursive: true });
}

/** ---------------- Guides ---------------- */

function mirrorGuides(srcRoot, outRoot) {
	let copied = 0;
	let skipped = 0;
	const walk = (src, out) => {
		const entries = fs.readdirSync(src, { withFileTypes: true });
		for (const entry of entries) {
			const srcPath = path.join(src, entry.name);
			const outPath = path.join(out, entry.name);
			if (entry.isDirectory()) {
				if (SKIP_DIR_NAMES.has(entry.name.toLowerCase())) {
					skipped++;
					continue;
				}
				walk(srcPath, outPath);
			} else if (entry.isFile()) {
				const ext = path.extname(entry.name).toLowerCase();
				if (!TEXT_EXTENSIONS.has(ext)) {
					skipped++;
					continue;
				}
				ensureDir(out);
				fs.copyFileSync(srcPath, outPath);
				copied++;
			}
		}
	};
	walk(srcRoot, outRoot);
	return { copied, skipped };
}

/** ---------------- API ---------------- */

function nsSlug(ns) {
	if (!ns) return '_global';
	return ns.toLowerCase();
}

function fileSafe(name) {
	// Sanitise to a filename. Keeps dots and dashes, replaces other unsafe chars.
	return name.replace(/[<>:"/\\|?*`]/g, '-').replace(/-+/g, '-').replace(/^-|-$/g, '');
}

function shortName(fullName) {
	// Strip namespace prefix for display.
	const lastDot = fullName.lastIndexOf('.');
	return lastDot < 0 ? fullName : fullName.slice(lastDot + 1);
}

/**
 * .NET reflection embeds the generic arity in the raw type name as a backtick
 * followed by a digit (e.g. `List`1`, `Dictionary`2`). Those backticks break
 * markdown inline code spans and add no information once we already see the
 * `<T>` part. Strip them everywhere we render a type reference.
 */
function stripArity(s) {
	if (!s) return s;
	return String(s).replace(/`\d+/g, '');
}

/**
 * Strip the most common XML doc tags so the markdown output is human readable
 * without sacrificing the underlying reference. We do not try to be exhaustive,
 * just clean up the noise that hurts AI consumption.
 */
function cleanDoc(s) {
	if (!s) return '';
	let out = String(s);
	out = out.replace(/<see\s+cref="[A-Z]:([^"]+)"\s*\/>/g, (_m, ref) => `\`${ref}\``);
	out = out.replace(/<see\s+cref="([^"]+)"\s*\/>/g, (_m, ref) => `\`${ref}\``);
	out = out.replace(/<see\s+langword="([^"]+)"\s*\/>/g, (_m, kw) => `\`${kw}\``);
	out = out.replace(/<paramref\s+name="([^"]+)"\s*\/>/g, (_m, n) => `\`${n}\``);
	out = out.replace(/<typeparamref\s+name="([^"]+)"\s*\/>/g, (_m, n) => `\`${n}\``);
	out = out.replace(/<\/?c>/g, '`');
	out = out.replace(/<code>([\s\S]*?)<\/code>/g, (_m, body) => `\n\n\`\`\`\n${body}\n\`\`\`\n\n`);
	out = out.replace(/<para>([\s\S]*?)<\/para>/g, (_m, body) => `\n\n${body.trim()}\n\n`);
	out = out.replace(/<list[^>]*>|<\/list>/g, '');
	out = out.replace(/<item[^>]*>([\s\S]*?)<\/item>/g, (_m, body) => `- ${body.trim()}`);
	out = out.replace(/<description>|<\/description>/g, '');
	out = out.replace(/<term>|<\/term>/g, '');
	out = out.replace(/<inheritdoc[^/]*\/>/g, '');
	// Strip any stray HTML colour styling that leaked in from the doc tooling.
	out = out.replace(/<span[^>]*>([\s\S]*?)<\/span>/g, (_m, body) => body);
	return out.trim();
}

function paramList(params) {
	if (!params || params.length === 0) return '';
	return params.map((p) => `${stripArity(p.Type)} ${p.Name}`).join(', ');
}

function methodSignature(m) {
	const ret = stripArity(m.ReturnType) || 'void';
	const mods = [];
	if (m.IsStatic) mods.push('static');
	if (m.IsAbstract) mods.push('abstract');
	if (m.IsVirtual) mods.push('virtual');
	const prefix = mods.length ? `${mods.join(' ')} ` : '';
	return `${prefix}${ret} ${stripArity(m.Name)}(${paramList(m.Parameters)})`;
}

function constructorSignature(t, c) {
	return `${stripArity(shortName(t.FullName))}(${paramList(c.Parameters)})`;
}

function propertyLine(p) {
	const mods = [];
	if (p.IsStatic) mods.push('static');
	const prefix = mods.length ? `${mods.join(' ')} ` : '';
	return `${prefix}${stripArity(p.PropertyType)} ${p.Name}`;
}

function fieldLine(f) {
	const mods = [];
	if (f.IsStatic) mods.push('static');
	if (f.IsConst) mods.push('const');
	if (f.IsReadOnly) mods.push('readonly');
	const prefix = mods.length ? `${mods.join(' ')} ` : '';
	return `${prefix}${stripArity(f.FieldType || f.Type)} ${f.Name}`;
}

function locFor(member) {
	const l = member.l || member.Loc;
	if (!l || !l.File) return '';
	return `_(${l.File}:${l.Line})_`;
}

function typeKindLabel(t) {
	if (t.IsEnum) return 'enum';
	if (t.IsInterface) return 'interface';
	if (t.IsValueType && !t.IsEnum) return 'struct';
	if (t.IsAttribute) return 'attribute';
	if (t.IsClass) {
		// In C# IL, a `static class` is emitted as both abstract and sealed.
		// Display "static class" rather than the redundant "static abstract sealed class".
		if (t.IsStatic) return 'static class';
		const mods = [];
		if (t.IsAbstract) mods.push('abstract');
		if (t.IsSealed) mods.push('sealed');
		mods.push('class');
		return mods.join(' ');
	}
	return t.Group || 'type';
}

function renderType(t) {
	const lines = [];
	const display = stripArity(t.FullName || t.Name);
	lines.push(`# ${display}`);
	lines.push('');

	const summary = cleanDoc(t.Documentation && t.Documentation.Summary);
	if (summary) {
		lines.push(summary);
		lines.push('');
	}

	lines.push(`- **Kind:** ${typeKindLabel(t)}`);
	lines.push(`- **Namespace:** \`${t.Namespace || '(global)'}\``);
	lines.push(`- **Assembly:** \`${t.Assembly || '?'}\``);
	if (t.BaseType) lines.push(`- **Base:** \`${stripArity(t.BaseType)}\``);
	if (t.DeclaringType) lines.push(`- **Declaring type:** \`${stripArity(t.DeclaringType)}\``);
	lines.push('');

	if (t.IsEnum && Array.isArray(t.Fields) && t.Fields.length > 0) {
		lines.push('## Values');
		lines.push('');
		for (const f of t.Fields) {
			const summary = cleanDoc(f.Documentation && f.Documentation.Summary);
			lines.push(`- \`${f.Name}\`${summary ? ` - ${summary}` : ''}`);
		}
		lines.push('');
	}

	if (Array.isArray(t.Constructors) && t.Constructors.length > 0) {
		lines.push('## Constructors');
		lines.push('');
		for (const c of t.Constructors) {
			lines.push(`- \`${constructorSignature(t, c)}\``);
			const summary = cleanDoc(c.Documentation && c.Documentation.Summary);
			if (summary) lines.push(`  - ${summary}`);
			if (c.Documentation && c.Documentation.Params) {
				for (const [pn, pd] of Object.entries(c.Documentation.Params)) {
					const cleaned = cleanDoc(pd);
					if (cleaned) lines.push(`  - \`${pn}\`: ${cleaned}`);
				}
			}
		}
		lines.push('');
	}

	if (Array.isArray(t.Properties) && t.Properties.length > 0) {
		lines.push('## Properties');
		lines.push('');
		for (const p of t.Properties) {
			lines.push(`- \`${propertyLine(p)}\``);
			const summary = cleanDoc(p.Documentation && p.Documentation.Summary);
			if (summary) lines.push(`  - ${summary}`);
		}
		lines.push('');
	}

	if (!t.IsEnum && Array.isArray(t.Fields) && t.Fields.length > 0) {
		lines.push('## Fields');
		lines.push('');
		for (const f of t.Fields) {
			lines.push(`- \`${fieldLine(f)}\``);
			const summary = cleanDoc(f.Documentation && f.Documentation.Summary);
			if (summary) lines.push(`  - ${summary}`);
		}
		lines.push('');
	}

	if (Array.isArray(t.Methods) && t.Methods.length > 0) {
		lines.push('## Methods');
		lines.push('');
		// Group static vs instance for legibility on big types.
		const staticMethods = t.Methods.filter((m) => m.IsStatic);
		const instanceMethods = t.Methods.filter((m) => !m.IsStatic);

		const renderMethodGroup = (label, ms) => {
			if (ms.length === 0) return;
			lines.push(`### ${label}`);
			lines.push('');
			for (const m of ms) {
				lines.push(`- \`${methodSignature(m)}\``);
				const summary = cleanDoc(m.Documentation && m.Documentation.Summary);
				if (summary) lines.push(`  - ${summary}`);
				if (m.Documentation && m.Documentation.Params) {
					for (const [pn, pd] of Object.entries(m.Documentation.Params)) {
						const cleaned = cleanDoc(pd);
						if (cleaned) lines.push(`  - \`${pn}\`: ${cleaned}`);
					}
				}
				const ret = cleanDoc(m.Documentation && m.Documentation.Return);
				if (ret) lines.push(`  - returns: ${ret}`);
			}
			lines.push('');
		};

		renderMethodGroup('Static methods', staticMethods);
		renderMethodGroup('Instance methods', instanceMethods);
	}

	return lines.join('\n');
}

function renderNamespaceIndex(ns, types) {
	const display = ns || '(global)';
	const lines = [];
	lines.push(`# Namespace \`${display}\``);
	lines.push('');
	lines.push(`${types.length} type${types.length === 1 ? '' : 's'}.`);
	lines.push('');
	const sorted = [...types].sort((a, b) => a.Name.localeCompare(b.Name));
	const groups = {
		'Classes': sorted.filter((t) => t.IsClass && !t.IsAttribute && !t.IsStatic),
		'Static classes': sorted.filter((t) => t.IsClass && t.IsStatic),
		'Attributes': sorted.filter((t) => t.IsAttribute),
		'Interfaces': sorted.filter((t) => t.IsInterface),
		'Structs': sorted.filter((t) => t.IsValueType && !t.IsEnum),
		'Enums': sorted.filter((t) => t.IsEnum)
	};
	for (const [label, list] of Object.entries(groups)) {
		if (list.length === 0) continue;
		lines.push(`## ${label}`);
		lines.push('');
		for (const t of list) {
			const summary = cleanDoc(t.Documentation && t.Documentation.Summary).split('\n')[0];
			const link = `./${fileSafe(t.Name)}.md`;
			lines.push(`- [\`${stripArity(t.Name)}\`](${link})${summary ? ` - ${summary}` : ''}`);
		}
		lines.push('');
	}
	return lines.join('\n');
}

function renderGlobalIndex(types) {
	const lines = [];
	lines.push('# API reference - alphabetical index');
	lines.push('');
	lines.push(`${types.length} public types across all namespaces. Click a type to see its members.`);
	lines.push('');
	// Sort by short Name so the alphabetical headings group everything correctly.
	// Tie-break by FullName so types of the same name from different namespaces
	// stay in deterministic order.
	const sorted = [...types].sort((a, b) => {
		const an = a.Name.toLowerCase();
		const bn = b.Name.toLowerCase();
		if (an !== bn) return an < bn ? -1 : 1;
		return a.FullName.localeCompare(b.FullName);
	});
	let lastInitial = '';
	for (const t of sorted) {
		const initial = (t.Name[0] || '#').toUpperCase();
		if (initial !== lastInitial) {
			lines.push(`## ${initial}`);
			lines.push('');
			lastInitial = initial;
		}
		const slug = nsSlug(t.Namespace);
		const file = fileSafe(t.Name);
		const link = `./namespaces/${slug}/${file}.md`;
		const ns = t.Namespace ? `\`${t.Namespace}\`` : '`(global)`';
		lines.push(`- [\`${stripArity(t.Name)}\`](${link}) - ${ns}`);
	}
	return lines.join('\n');
}

function renderByNamespaceIndex(byNs) {
	const lines = [];
	lines.push('# API reference - by namespace');
	lines.push('');
	const namespaces = [...byNs.keys()].sort((a, b) => {
		// (global) at the bottom for readability.
		if (a === '') return 1;
		if (b === '') return -1;
		return a.localeCompare(b);
	});
	for (const ns of namespaces) {
		const slug = nsSlug(ns);
		const types = byNs.get(ns);
		const display = ns || '(global)';
		lines.push(`## \`${display}\``);
		lines.push('');
		lines.push(`[Open namespace index](./namespaces/${slug}/_index.md) - ${types.length} type${types.length === 1 ? '' : 's'}.`);
		lines.push('');
	}
	return lines.join('\n');
}

function generateApi(jsonPath, outRoot) {
	const json = JSON.parse(fs.readFileSync(jsonPath, 'utf8'));
	const types = json.Types || [];
	const byNs = new Map();
	for (const t of types) {
		const ns = t.Namespace || '';
		if (!byNs.has(ns)) byNs.set(ns, []);
		byNs.get(ns).push(t);
	}

	ensureDir(outRoot);
	const namespacesRoot = path.join(outRoot, 'namespaces');
	ensureDir(namespacesRoot);

	let typeFiles = 0;
	const collisions = new Map();

	for (const [ns, list] of byNs) {
		const slug = nsSlug(ns);
		const dir = path.join(namespacesRoot, slug);
		ensureDir(dir);

		const usedNames = new Map();
		for (const t of list) {
			let base = fileSafe(t.Name);
			if (!base) base = '_unnamed';
			const count = (usedNames.get(base) || 0) + 1;
			usedNames.set(base, count);
			const finalName = count === 1 ? base : `${base}_${count}`;
			if (count > 1) collisions.set(`${ns}::${t.Name}`, finalName);
			fs.writeFileSync(path.join(dir, `${finalName}.md`), renderType(t));
			typeFiles++;
		}

		fs.writeFileSync(path.join(dir, '_index.md'), renderNamespaceIndex(ns, list));
	}

	fs.writeFileSync(path.join(outRoot, 'INDEX.md'), renderGlobalIndex(types));
	fs.writeFileSync(path.join(outRoot, 'INDEX_BY_NAMESPACE.md'), renderByNamespaceIndex(byNs));

	return { typeFiles, namespaces: byNs.size, collisions: collisions.size };
}

/** ---------------- Main ---------------- */

function main() {
	if (!fs.existsSync(SRC_GUIDES)) {
		console.error(`Missing source: ${SRC_GUIDES}`);
		process.exit(1);
	}
	if (!fs.existsSync(SRC_API)) {
		console.error(`Missing source: ${SRC_API}`);
		process.exit(1);
	}

	console.log('==> Wiping previous Docs/Sbox/guides and Docs/Sbox/api');
	rmrf(OUT_GUIDES);
	rmrf(OUT_API);

	console.log('==> Mirroring guides (text-only)');
	const g = mirrorGuides(SRC_GUIDES, OUT_GUIDES);
	console.log(`    copied ${g.copied} files, skipped ${g.skipped} non-text entries`);

	console.log('==> Generating API reference');
	const a = generateApi(SRC_API, OUT_API);
	console.log(`    wrote ${a.typeFiles} type files across ${a.namespaces} namespaces (${a.collisions} name collisions disambiguated)`);

	console.log('Done. Output: Docs/Sbox/');
}

main();
