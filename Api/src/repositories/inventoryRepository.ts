/**
 * @author Epyi
 */

import type { Pool, PoolConnection, ResultSetHeader, RowDataPacket } from 'mysql2/promise';

import { pool } from '../db/pool.js';
import type { InventoryEntry, InventorySlotUpsert } from '../schemas/inventory.js';

type Conn = Pool | PoolConnection;

export async function listForCharacter(
	characterId: string,
	conn: Conn = pool
): Promise<InventoryEntry[]> {
	const [rows] = await conn.query<RowDataPacket[]>(
		`SELECT slot, item_id, quantity, metadata
		   FROM character_inventory
		  WHERE character_id = ?
		    AND quantity > 0
		  ORDER BY slot ASC`,
		[characterId]
	);
	return rows.map((r) => ({
		slot: Number(r['slot']),
		itemId: String(r['item_id']),
		quantity: Number(r['quantity']),
		metadata: parseMetadata(r['metadata'])
	}));
}

export async function upsertSlot(
	characterId: string,
	slot: number,
	entry: InventorySlotUpsert,
	conn: Conn = pool
): Promise<void> {
	const meta = entry.metadata == null ? null : JSON.stringify(entry.metadata);
	await conn.query<ResultSetHeader>(
		`INSERT INTO character_inventory (character_id, slot, item_id, quantity, metadata)
		 VALUES (?, ?, ?, ?, ?)
		 ON DUPLICATE KEY UPDATE
		   item_id  = VALUES(item_id),
		   quantity = VALUES(quantity),
		   metadata = VALUES(metadata)`,
		[characterId, slot, entry.itemId, entry.quantity, meta]
	);
}

export async function clearSlot(
	characterId: string,
	slot: number,
	conn: Conn = pool
): Promise<number> {
	const [result] = await conn.query<ResultSetHeader>(
		'DELETE FROM character_inventory WHERE character_id = ? AND slot = ?',
		[characterId, slot]
	);
	return result.affectedRows;
}

/**
 * Replace the entire inventory for a character in one shot. Wipes every
 * existing row then bulk-inserts the new ones. Always called from within
 * a transaction (snapshot save) so a failure does not leave the
 * inventory in a half-written state.
 */
export async function replaceAll(
	characterId: string,
	entries: InventoryEntry[],
	conn: PoolConnection
): Promise<void> {
	await conn.query<ResultSetHeader>(
		'DELETE FROM character_inventory WHERE character_id = ?',
		[characterId]
	);
	if (entries.length === 0) return;
	const placeholders = entries.map(() => '(?, ?, ?, ?, ?)').join(', ');
	const params: unknown[] = [];
	for (const entry of entries) {
		const meta = entry.metadata == null ? null : JSON.stringify(entry.metadata);
		params.push(characterId, entry.slot, entry.itemId, entry.quantity, meta);
	}
	await conn.query<ResultSetHeader>(
		`INSERT INTO character_inventory (character_id, slot, item_id, quantity, metadata)
		 VALUES ${placeholders}`,
		params
	);
}

function parseMetadata(value: unknown): Record<string, unknown> | null {
	if (value == null) return null;
	let parsed: unknown = value;
	if (typeof parsed === 'string') {
		try {
			parsed = JSON.parse(parsed);
		} catch {
			return null;
		}
	}
	if (!parsed || typeof parsed !== 'object' || Array.isArray(parsed)) return null;
	return parsed as Record<string, unknown>;
}
