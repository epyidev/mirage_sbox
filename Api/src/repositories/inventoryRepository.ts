/**
 * @author Epyi
 */

import type { Pool, PoolConnection, ResultSetHeader, RowDataPacket } from 'mysql2/promise';

import { pool } from '../db/pool.js';
import type { InventoryEntry } from '../schemas/profile.js';

type Conn = Pool | PoolConnection;

export async function listForPlayer(
	steamId: string,
	conn: Conn = pool
): Promise<InventoryEntry[]> {
	const [rows] = await conn.query<RowDataPacket[]>(
		`SELECT item_id, quantity, metadata
		 FROM player_inventory
		 WHERE steam_id = ? AND quantity > 0
		 ORDER BY item_id`,
		[steamId]
	);
	return rows.map((r) => ({
		itemId: String(r['item_id']),
		quantity: Number(r['quantity']),
		metadata: (r['metadata'] as Record<string, unknown> | null) ?? null
	}));
}

export async function addItem(
	conn: PoolConnection,
	steamId: string,
	itemId: string,
	quantity: number
): Promise<void> {
	if (quantity <= 0) return;
	await conn.query<ResultSetHeader>(
		`INSERT INTO player_inventory (steam_id, item_id, quantity)
		 VALUES (?, ?, ?)
		 ON DUPLICATE KEY UPDATE quantity = quantity + VALUES(quantity)`,
		[steamId, itemId, quantity]
	);
}
