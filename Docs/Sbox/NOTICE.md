# Notice and attribution

## `guides/`

The `guides/` folder is a derivative work of:

- **Source:** Facepunch/sbox-docs (https://github.com/Facepunch/sbox-docs)
- **License:** Creative Commons Attribution 4.0 International (CC BY 4.0)
- **License text:** https://creativecommons.org/licenses/by/4.0/legalcode

Modifications applied when generating `guides/` from the upstream:

- Only `*.md` and `*.yml` files are retained.
- All `images/`, video, and other binary assets are dropped.
- Otherwise, file contents are kept verbatim. Image and video links inside the markdown remain as text references; they will not resolve in this mirror.

## `api/`

The `api/` folder is generated programmatically from an auto-generated JSON dump of the s&box public API reference (the same data that powers `https://sbox.game/api/`). The generator script (`tools/sbox-docs/generate.mjs`) reads the JSON, normalises type information (strips reflection arity markers, cleans XML doc tags), and emits one markdown file per type. The descriptive text in each file comes from the XML doc comments shipped with the s&box assemblies. Attribution to Facepunch under CC BY 4.0 applies to that text.

## Hand-written content

`SKILL.md`, `README.md`, `NOTICE.md`, and everything under `reference/` are hand-written for this project. They follow the licence of the parent Mirage project (see `../../LICENSE`).
