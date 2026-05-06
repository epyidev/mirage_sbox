/**
 * @author Epyi
 */

import mysql, { type Pool, type PoolConnection } from 'mysql2/promise';

import { env } from '../config/env.js';

export const pool: Pool = mysql.createPool({
	host: env.DATABASE_HOST,
	port: env.DATABASE_PORT,
	user: env.DATABASE_USER,
	password: env.DATABASE_PASSWORD,
	database: env.DATABASE_NAME,
	connectionLimit: env.DATABASE_CONNECTION_LIMIT,
	waitForConnections: true,
	queueLimit: 0,
	enableKeepAlive: true,
	keepAliveInitialDelay: 10_000,
	timezone: 'Z',
	dateStrings: false,
	supportBigNumbers: true,
	bigNumberStrings: true,
	multipleStatements: false,
	namedPlaceholders: false
});

/**
 * Run `fn` inside a SQL transaction, committing on success and rolling back on
 * any thrown error. The connection is always released back to the pool.
 */
export async function withTransaction<T>(
	fn: (conn: PoolConnection) => Promise<T>
): Promise<T> {
	const conn = await pool.getConnection();
	try {
		await conn.beginTransaction();
		const result = await fn(conn);
		await conn.commit();
		return result;
	} catch (err) {
		try {
			await conn.rollback();
		} catch {
			// the connection may already be poisoned, ignore the rollback failure
		}
		throw err;
	} finally {
		conn.release();
	}
}

export async function shutdownPool(): Promise<void> {
	await pool.end();
}
