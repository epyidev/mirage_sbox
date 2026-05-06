/**
 * @author Epyi
 *
 * Tiny SQL migration runner. Applies any *.sql file under ../../migrations/
 * that has not yet run, in lexicographic order. Tracks applied files in a
 * `_migrations` table. Each file runs in its own transaction.
 */

import { readFile, readdir } from 'node:fs/promises';
import { dirname, join } from 'node:path';
import { fileURLToPath } from 'node:url';

import type { PoolConnection, RowDataPacket } from 'mysql2/promise';

import { pool, shutdownPool } from './pool.js';

const here = dirname(fileURLToPath(import.meta.url));
const migrationsDir = join(here, '..', '..', 'migrations');

async function ensureMigrationsTable(conn: PoolConnection): Promise<void> {
	await conn.query(`
		CREATE TABLE IF NOT EXISTS _migrations (
			id          VARCHAR(255) NOT NULL,
			applied_at  DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP,
			PRIMARY KEY (id)
		) ENGINE = InnoDB
		  DEFAULT CHARSET = utf8mb4
		  COLLATE = utf8mb4_unicode_ci
	`);
}

async function readApplied(conn: PoolConnection): Promise<Set<string>> {
	const [rows] = await conn.query<RowDataPacket[]>('SELECT id FROM _migrations');
	return new Set(rows.map((r) => String(r['id'])));
}

async function listMigrationFiles(): Promise<string[]> {
	const files = await readdir(migrationsDir);
	return files.filter((f) => f.endsWith('.sql')).sort();
}

function splitStatements(sql: string): string[] {
	return sql
		.split(/;\s*(?:\r?\n|$)/)
		.map((s) => s.trim())
		.filter((s) => s.length > 0 && !/^\s*--/.test(s));
}

async function applyFile(conn: PoolConnection, file: string, sql: string): Promise<void> {
	const statements = splitStatements(sql);
	for (const stmt of statements) {
		await conn.query(stmt);
	}
	await conn.query('INSERT INTO _migrations (id) VALUES (?)', [file]);
}

async function main(): Promise<void> {
	const conn = await pool.getConnection();
	try {
		await ensureMigrationsTable(conn);
		const applied = await readApplied(conn);
		const files = await listMigrationFiles();
		const pending = files.filter((f) => !applied.has(f));

		if (pending.length === 0) {
			console.log('Migrations: nothing to do.');
			return;
		}

		console.log(`Migrations: applying ${pending.length} file(s).`);
		for (const file of pending) {
			const fullPath = join(migrationsDir, file);
			const sql = await readFile(fullPath, 'utf8');
			console.log(`  -> ${file}`);
			await conn.beginTransaction();
			try {
				await applyFile(conn, file, sql);
				await conn.commit();
			} catch (err) {
				await conn.rollback();
				throw err;
			}
		}
		console.log('Migrations: done.');
	} finally {
		conn.release();
		await shutdownPool();
	}
}

main().catch((err: unknown) => {
	console.error('Migration failed:', err);
	process.exit(1);
});
