/**
 * @author Epyi
 */

import type { Pool, PoolConnection, ResultSetHeader, RowDataPacket } from 'mysql2/promise';

import { pool } from '../db/pool.js';

type Conn = Pool | PoolConnection;

export async function listForPlayer(
	steamId: string,
	conn: Conn = pool
): Promise<string[]> {
	const [rows] = await conn.query<RowDataPacket[]>(
		`SELECT permission FROM permissions_player_permissions
		  WHERE steam_id = ?
		  ORDER BY permission ASC`,
		[steamId]
	);
	return rows.map((r) => String(r['permission']));
}

export async function addPermission(
	steamId: string,
	permission: string,
	conn: Conn = pool
): Promise<void> {
	await conn.query<ResultSetHeader>(
		'INSERT IGNORE INTO permissions_player_permissions (steam_id, permission) VALUES (?, ?)',
		[steamId, permission]
	);
}

export async function removePermission(
	steamId: string,
	permission: string,
	conn: Conn = pool
): Promise<number> {
	const [result] = await conn.query<ResultSetHeader>(
		'DELETE FROM permissions_player_permissions WHERE steam_id = ? AND permission = ?',
		[steamId, permission]
	);
	return result.affectedRows;
}

/**
 * List every Steam id that has at least one direct override row, with the
 * count of overrides. Every row in `permissions_player_permissions` is an
 * override by definition, since `_group.default` is implicit and never
 * persisted, so we just count rows.
 */
export async function listOverrides(
	conn: Conn = pool
): Promise<{ steam_id: string; count: number }[]> {
	const [rows] = await conn.query<RowDataPacket[]>(
		`SELECT steam_id, COUNT(*) AS cnt
		   FROM permissions_player_permissions
		  GROUP BY steam_id
		 HAVING cnt > 0
		  ORDER BY steam_id ASC`
	);
	return rows.map((r) => ({
		steam_id: String(r['steam_id']),
		count: Number(r['cnt'])
	}));
}
