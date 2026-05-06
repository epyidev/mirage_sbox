/**
 * @author Epyi
 */

import type { Pool, PoolConnection, ResultSetHeader, RowDataPacket } from 'mysql2/promise';

import { pool } from '../db/pool.js';
import type { ProfileSnapshot } from '../schemas/profile.js';

export interface PlayerRow {
	steam_id: string;
	display_name: string;
	cash_money: number;
	bank_money: number;
	last_pos_x: number | null;
	last_pos_y: number | null;
	last_pos_z: number | null;
	last_yaw: number | null;
	last_seen_at: Date;
	created_at: Date;
	updated_at: Date;
}

type Conn = Pool | PoolConnection;

export async function findBySteamId(steamId: string, conn: Conn = pool): Promise<PlayerRow | null> {
	const [rows] = await conn.query<RowDataPacket[]>(
		'SELECT * FROM players WHERE steam_id = ? LIMIT 1',
		[steamId]
	);
	return (rows[0] as PlayerRow | undefined) ?? null;
}

export async function findBySteamIdForUpdate(
	conn: PoolConnection,
	steamId: string
): Promise<PlayerRow | null> {
	const [rows] = await conn.query<RowDataPacket[]>(
		'SELECT * FROM players WHERE steam_id = ? FOR UPDATE',
		[steamId]
	);
	return (rows[0] as PlayerRow | undefined) ?? null;
}

export async function createIfMissing(steamId: string, conn: Conn = pool): Promise<void> {
	await conn.query<ResultSetHeader>(
		`INSERT INTO players (steam_id) VALUES (?)
		 ON DUPLICATE KEY UPDATE last_seen_at = CURRENT_TIMESTAMP`,
		[steamId]
	);
}

export async function updateSnapshot(
	steamId: string,
	patch: ProfileSnapshot,
	conn: Conn = pool
): Promise<void> {
	const fields: string[] = [];
	const values: unknown[] = [];

	if (patch.displayName !== undefined) {
		fields.push('display_name = ?');
		values.push(patch.displayName);
	}
	if (patch.cashMoney !== undefined) {
		fields.push('cash_money = ?');
		values.push(patch.cashMoney);
	}
	if (patch.bankMoney !== undefined) {
		fields.push('bank_money = ?');
		values.push(patch.bankMoney);
	}
	if (patch.lastPosition !== undefined) {
		fields.push('last_pos_x = ?', 'last_pos_y = ?', 'last_pos_z = ?', 'last_yaw = ?');
		values.push(
			patch.lastPosition.x,
			patch.lastPosition.y,
			patch.lastPosition.z,
			patch.lastPosition.yaw
		);
	}

	fields.push('last_seen_at = CURRENT_TIMESTAMP');
	values.push(steamId);

	await conn.query<ResultSetHeader>(
		`UPDATE players SET ${fields.join(', ')} WHERE steam_id = ?`,
		values
	);
}

export async function debit(
	conn: PoolConnection,
	steamId: string,
	currency: 'cash' | 'bank',
	amount: number
): Promise<void> {
	const column = currency === 'cash' ? 'cash_money' : 'bank_money';
	await conn.query<ResultSetHeader>(
		`UPDATE players SET ${column} = ${column} - ? WHERE steam_id = ?`,
		[amount, steamId]
	);
}
