<h1 align='center'>Mirage API</h1>
<p align='center'><b>Backend service for the Mirage roleplay gamemode. Persists player data and arbitrates server-authoritative actions on top of MariaDB. Called over HTTP by the s&box host running the gamemode.</b></p>

## Why this exists

The s&box gamemode runs inside a managed code sandbox that blocks raw socket access and SQL drivers. The host process can only reach external services through `Sandbox.Http`. This API is the bridge between the gamemode and the database.

```
[ Client s&box ] <-- RPC --> [ Host s&box (sandboxed) ] <-- HTTP --> [ Mirage API (this) ] <-- SQL --> [ MariaDB ]
```

The API is the source of truth for persistent state. The model splits OOC and IC concerns:

- A `players` row carries OOC identity tied to a Steam account: display name, IP history.
- A `characters` row is one RP character owned by a player, indexed by `slot` so a single Steam account can keep several saved characters. It carries the RP identity (`first_name`, `last_name`, `birth_date`, `height_cm`, `gender`) plus the last known position.
- `accounts` is one row per wallet per character (`character_id`, `account_id`, `amount`). Defaults `cash` and `bank` are seeded on character creation; new wallet ids can be added on the fly through the API.
- `character_inventory` is one row per occupied slot per character (`character_id`, `slot`, `item_id`, `quantity`, optional `metadata` JSON).

The host holds an in-memory cache of an active character, syncs it back via the API as gameplay state changes, and flushes on disconnect.

## Stack

- **Node.js 20+** with **TypeScript 5** in strict mode.
- **Fastify 5** as the HTTP server.
- **Zod** for runtime validation, with `fastify-type-provider-zod` to derive route types from schemas.
- **mysql2** as the MariaDB / MySQL driver, used through a connection pool.
- **Pino** (Fastify-bundled) for structured JSON logs.
- **Plain SQL schema** in `import.sql`, imported once into an empty database.

## Layout

```
Api/
  import.sql              Full SQL schema, imported once into an empty database.
  src/
    config/env.ts         Zod-validated environment loader.
    db/pool.ts            mysql2 connection pool plus withTransaction helper.
    middleware/auth.ts    Bearer-token auth hook.
    repositories/         One file per table, raw SQL behind typed methods.
    routes/               Fastify route plugins (health, players, characters).
    schemas/              Shared Zod schemas.
    services/             Cross-repo flows that need a SQL transaction.
    app.ts                Builds the Fastify instance.
    server.ts             Entry point, wires signals and listen.
```

The repository layer wraps SQL queries. The service layer composes them inside a SQL transaction when more than one table is involved. The route layer maps HTTP to repos and services, and handles validation. No layer skips the next.

## Requirements

- Node.js 20.10 or later (LTS recommended)
- MariaDB 10.6 or later, or MySQL 8.0 or later
- A user with `SELECT, INSERT, UPDATE, DELETE` on the target database (plus the privileges needed to import `import.sql` once)

## Setup

1. Install dependencies:

   ```bash
   npm install
   ```

2. Copy the env template and fill in the values:

   ```bash
   cp .env.example .env
   # then edit .env
   ```

   Generate a strong bearer token with `openssl rand -hex 32`. Minimum 32 characters.

3. Create the database (one-time):

   ```sql
   CREATE DATABASE mirage CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
   CREATE USER 'mirage'@'%' IDENTIFIED BY 'changeme';
   GRANT ALL PRIVILEGES ON mirage.* TO 'mirage'@'%';
   FLUSH PRIVILEGES;
   ```

4. Import the schema (one-time):

   ```bash
   mysql -u mirage -p mirage < import.sql
   ```

## Run

Development with hot reload:

```bash
npm run dev
```

Production:

```bash
npm run build
npm start
```

## Auth

Every endpoint except `/health` requires a Bearer token in the `Authorization` header:

```
Authorization: Bearer <API_BEARER_TOKEN>
```

The token must match `API_BEARER_TOKEN` from `.env` byte for byte (constant-time compared). There is no rotation or refresh, this is a server-to-server secret. The s&box host is the only legitimate caller.

## Endpoints

All character data sits under the owning player's path. Every character endpoint refuses to return or mutate a character whose `steam_id` does not match the URL, so a steam id cannot probe character ids that belong to someone else.

OOC (player-level):

| Method | Path                                  | Purpose                                                            |
|--------|---------------------------------------|--------------------------------------------------------------------|
| GET    | `/health`                             | Liveness probe, no auth, also pings the database.                  |
| GET    | `/players/:steamId`                   | Load OOC profile (display name, IP history). Creates the row if missing. |
| PUT    | `/players/:steamId`                   | Update OOC fields: `displayName`, `recordIp` (appends or refreshes the timestamp on the entry). |
| GET    | `/players/:steamId/characters`        | List the player's character summaries.                             |
| POST   | `/players/:steamId/characters`        | Create a character on a free `slot`. Body: `slot`, `firstName`, `lastName`, `birthDate` (ISO `YYYY-MM-DD`), `heightCm` (50 to 272), `gender` (`m` or `f`). Returns 409 if the slot is taken. |

IC (character-level):

| Method | Path                                                                | Purpose                                                                                  |
|--------|---------------------------------------------------------------------|------------------------------------------------------------------------------------------|
| GET    | `/players/:steamId/characters/:characterId`                         | Full character bundle: summary plus accounts plus inventory.                             |
| PUT    | `/players/:steamId/characters/:characterId`                         | Patch character fields (currently `lastPosition`).                                       |
| DELETE | `/players/:steamId/characters/:characterId`                         | Delete the character. Cascades to its accounts and inventory rows.                       |
| PUT    | `/players/:steamId/characters/:characterId/accounts/:accountId`     | Set the balance of a single wallet (`{ amount }`). Creates the wallet row if missing.    |
| DELETE | `/players/:steamId/characters/:characterId/accounts/:accountId`     | Remove a wallet row.                                                                     |
| PUT    | `/players/:steamId/characters/:characterId/inventory/:slot`         | Upsert the item in a slot (`itemId`, `quantity`, optional `metadata` JSON).              |
| DELETE | `/players/:steamId/characters/:characterId/inventory/:slot`         | Empty the slot.                                                                          |

Idempotency-by-design: `POST /players/:steamId/characters` is keyed on `(steam_id, slot)` so a replay returns 409 instead of creating a duplicate. All other writes are slot or row-keyed upserts, so retries converge.

## Schema changes

The schema lives in a single `import.sql` file, imported once into an empty database. There is no migration runner. When the schema changes during development, drop and recreate the database, then re-import. Once the project hits a real persistent environment, switch to a real migration tool before applying changes in place.

## Production deployment

The API is meant to run as a sidecar next to the s&box dedicated server, listening on a private interface (typically `127.0.0.1`). Expose only the dedicated server's game port to the public, the API stays behind the firewall.

A `systemd` unit example:

```ini
[Unit]
Description=Mirage API
After=network.target mariadb.service

[Service]
Type=simple
User=mirage
WorkingDirectory=/opt/mirage/api
EnvironmentFile=/opt/mirage/api/.env
ExecStart=/usr/bin/node dist/server.js
Restart=always
RestartSec=5

[Install]
WantedBy=multi-user.target
```

## License

Same license as the rest of the Mirage project. See [../LICENSE](../LICENSE).
