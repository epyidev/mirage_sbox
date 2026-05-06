<h1 align='center'>Mirage API</h1>
<p align='center'><b>Backend service for the Mirage roleplay gamemode. Persists player data and arbitrates server-authoritative actions on top of MariaDB. Called over HTTP by the s&box host running the gamemode.</b></p>

## Why this exists

The s&box gamemode runs inside a managed code sandbox that blocks raw socket access and SQL drivers. The host process can only reach external services through `Sandbox.Http`. This API is the bridge between the gamemode and the database.

```
[ Client s&box ] <-- RPC --> [ Host s&box (sandboxed) ] <-- HTTP --> [ Mirage API (this) ] <-- SQL --> [ MariaDB ]
```

The API is the source of truth for persistent state: identity, money, inventory, last position. The host holds an in-memory cache of an online player's profile, syncs it back via the API on transactions, and flushes on disconnect.

## Stack

- **Node.js 20+** with **TypeScript 5** in strict mode.
- **Fastify 5** as the HTTP server.
- **Zod** for runtime validation, with `fastify-type-provider-zod` to derive route types from schemas.
- **mysql2** as the MariaDB / MySQL driver, used through a connection pool.
- **Pino** (Fastify-bundled) for structured JSON logs.
- **Plain SQL migrations** numbered under `migrations/`, applied by a small Node runner.

## Layout

```
Api/
  migrations/             SQL schema migrations, applied in numeric order.
    001_init.sql
  src/
    config/env.ts         Zod-validated environment loader.
    db/pool.ts            mysql2 connection pool plus withTransaction helper.
    db/migrate.ts         Migration runner CLI.
    middleware/auth.ts    Bearer-token auth hook.
    repositories/         One file per table, raw SQL behind typed methods.
    routes/               Fastify route plugins (health, profiles, transactions).
    schemas/              Shared Zod schemas.
    services/             Business logic for transactional flows.
    app.ts                Builds the Fastify instance.
    server.ts             Entry point, wires signals and listen.
```

The repository layer wraps SQL queries. The service layer composes them inside a SQL transaction. The route layer maps HTTP to services and handles validation. No layer skips the next.

## Requirements

- Node.js 20.10 or later (LTS recommended)
- MariaDB 10.6 or later, or MySQL 8.0 or later
- A user with `SELECT, INSERT, UPDATE, DELETE, CREATE, ALTER, INDEX` on the target database

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

4. Apply migrations:

   ```bash
   npm run migrate
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

| Method | Path                    | Purpose                                              |
|--------|-------------------------|------------------------------------------------------|
| GET    | `/health`               | Liveness probe, no auth, also pings the database.    |
| GET    | `/profiles/:steamId`    | Load full player profile, creates the row if missing.|
| PUT    | `/profiles/:steamId`    | Save snapshot (display name, money, last position).  |
| POST   | `/transactions/buy`     | Atomic purchase: debit money, credit inventory.      |

All write endpoints accept a `transactionId` (UUID) for idempotency: replays return the original outcome without double effect.

## Migrations

Migrations are plain SQL files named `NNN_description.sql` under `migrations/`. The runner applies them in numeric order, tracks which ones ran in a `_migrations` table, and refuses to skip or reorder. Never rename or modify a migration that has been applied to a real database. Add a new migration instead.

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
