---
name: sbox
description: Reference for the s&box game engine: gamemode code, networking, ConVars, components, scenes, dedicated server, UI, HTTP, FileSystem, and the full Sandbox API across 1882 public types.
---

# s&box knowledge base

This folder is a static, curated dump of the official s&box documentation plus the auto-generated API reference. Use it whenever a question involves the s&box engine, the Sandbox API, gamemode code, networking, scene/components, the dedicated server, or how a feature is meant to be wired up.

## Layout

- `guides/` - text-only mirror of the official documentation (Facepunch/sbox-docs, CC BY 4.0). Mirrors the upstream tree (`networking/`, `code/`, `scene/`, `ui/`, `gameplay/`, `assets/`, `services/`, `physics/`, `editor/`, `rendering/`, ...). Images and videos are dropped, only `*.md` and `*.yml` are kept.
- `api/`
  - `INDEX.md` - alphabetical list of every public type (1882 types).
  - `INDEX_BY_NAMESPACE.md` - same data grouped by namespace.
  - `namespaces/<lowercase-namespace>/<TypeName>.md` - one file per type with summary, kind, base type, constructors, properties, fields, and methods.
- `reference/` - hand-curated digest cards focused on patterns we use in this project (ConVars, dedicated server, HTTP from the host, RPC, ownership, FileSystem, serverside code).

## Navigation rules

When the question is conceptual ("how does networking work", "what is a Component"), start in `guides/`. When the question is about exact API signatures ("what does `Http.RequestAsync` return"), open `api/INDEX.md` (or `Grep` the `api/namespaces/` folder). When the question is "how do we usually do X in this project's stack", check `reference/` first.

Use `Grep` over `Docs/Sbox/` rather than guessing. The dump is exhaustive and organised: if a public type or member is not in `api/INDEX.md`, it does not exist in this s&box version.

Do not invent API names or signatures. If something is not findable in this folder, say so explicitly rather than guessing. The CLAUDE.md root rule about not inventing s&box APIs applies double here.

## Source

- `guides/` is mirrored from `Facepunch/sbox-docs` (https://github.com/Facepunch/sbox-docs), licensed CC BY 4.0. Attribution and modification notes live in `NOTICE.md`.
- `api/` is generated from a JSON dump of the auto-generated API reference. The generator script lives at the repo root in `tools/sbox-docs/generate.mjs`.

## Refreshing

To re-sync from a fresh upstream drop:

1. Replace `Downloaded/Documentation/` with the new sbox-docs tree.
2. Replace `Downloaded/api_reference.json` with the new API dump.
3. Run `node tools/sbox-docs/generate.mjs` from the repo root.
4. The script wipes `guides/` and `api/`. `SKILL.md`, `README.md`, `NOTICE.md`, and `reference/` are preserved.
