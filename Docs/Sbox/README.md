# Docs/Sbox

Curated, AI-friendly reference for the s&box engine. Read `SKILL.md` first for the navigation rules.

## What is here

| Path | What it contains | Source |
|------|------------------|--------|
| `SKILL.md` | Navigation guide and rules. | hand-written |
| `README.md` | This file. | hand-written |
| `NOTICE.md` | License attribution for the upstream docs. | hand-written |
| `guides/` | Markdown documentation, mirror of `Facepunch/sbox-docs`. Images and videos dropped. | upstream, regenerated |
| `api/` | API reference for every public type, one file per type plus indexes. | upstream JSON, regenerated |
| `reference/` | Hand-curated digest cards for patterns we actually use in this project. | hand-written |

`guides/` and `api/` are regenerated from `Downloaded/` by `tools/sbox-docs/generate.mjs`. Do not hand-edit them, your changes will be wiped on the next regeneration. Hand-write things in `SKILL.md`, `README.md`, `NOTICE.md`, or `reference/`.

## Refresh procedure

1. Drop fresh upstream content under `Downloaded/`:
   - `Downloaded/Documentation/` should match the layout of `Facepunch/sbox-docs/docs/` on the chosen branch (master).
   - `Downloaded/api_reference.json` should be the API dump for the matching version.
2. From the repo root:

   ```powershell
   node tools/sbox-docs/generate.mjs
   ```

3. The script prints a summary: number of guide files copied, number of type files written, and the namespace count. Spot-check a few files in `guides/` and `api/namespaces/sandbox/` after regeneration.

## Why a separate `Docs/Sbox/` and not `.claude/skills/`

The user (Epyi) chose this layout: the skill content lives next to the project's own `Docs/`, not under the runtime-managed `.claude/skills/`. The folder is browsable from the repo, committed, and reviewable in PRs. If we ever want a real Claude Code auto-discoverable skill, we can add a thin `.claude/skills/sbox/SKILL.md` that imports from here.

## Scope and limits

- `guides/` covers the official documentation. It does not cover blog posts, hosting-provider knowledge bases, or YouTube tutorials.
- `api/` covers public types only. Internal types (those not surfaced in the API dump) are not here. If a type is not in `api/INDEX.md`, it is either internal or not in the version we synced from.
- Auto-generated docs may have minor formatting quirks (unresolved `<see cref>` cleanup, generic arity stripping). The generator does its best, but if a type page looks odd, sanity-check against the upstream.

## License

The upstream content under `guides/` is `CC BY 4.0` (Facepunch). See `NOTICE.md`. The hand-written `reference/`, `SKILL.md`, `README.md`, and `NOTICE.md` follow the rest of the Mirage project (see `../../LICENSE`).
