/**
 * @author Epyi
 */

import type { Pool, PoolConnection, ResultSetHeader, RowDataPacket } from 'mysql2/promise';

import { pool } from '../db/pool.js';
import type { AccountEntry } from '../schemas/account.js';

export interface AccountRow {
	character_id: string;
	account_id: string;
	amount: number;
	updated_at: Date;
}

type Conn = Pool | PoolConnection;

/**
 * Wallets seeded automatically on every new character. Add to this list when
 * gameplay introduces a new permanent wallet. New entries can also be created
 * later through `setAmount`, this list only fixes which ones must always exist.
 */
export const DEFAULT_ACCOUNT_IDS = ['cash', 'bank'] as const;

export async function listForCharacter(
	characterId: string,
	conn: Conn = pool
): Promise<AccountEntry[]> {
	const [rows] = await conn.query<RowDataPacket[]>(
		`SELECT account_id, amount, updated_at
		   FROM accounts
		  WHERE character_id = ?
		  ORDER BY account_id ASC`,
		[characterId]
	);
	return rows.map((r) => ({
		accountId: String(r['account_id']),
		amount: Number(r['amount']),
		updatedAt: (r['updated_at'] as Date).toISOString()
	}));
}

/**
 * Insert default wallet rows for a freshly-created character. Skipped silently
 * if the list is empty.
 */
export async function seedDefaults(
	conn: PoolConnection,
	characterId: string
): Promise<void> {
	const ids: readonly string[] = DEFAULT_ACCOUNT_IDS;
	if (ids.length === 0) return;
	const placeholders = ids.map(() => '(?, ?, 0)').join(', ');
	const params: unknown[] = [];
	for (const id of ids) {
		params.push(characterId, id);
	}
	await conn.query<ResultSetHeader>(
		`INSERT INTO accounts (character_id, account_id, amount) VALUES ${placeholders}`,
		params
	);
}

export async function setAmount(
	characterId: string,
	accountId: string,
	amount: number,
	conn: Conn = pool
): Promise<void> {
	await conn.query<ResultSetHeader>(
		`INSERT INTO accounts (character_id, account_id, amount)
		 VALUES (?, ?, ?)
		 ON DUPLICATE KEY UPDATE amount = VALUES(amount)`,
		[characterId, accountId, amount]
	);
}

export async function deleteAccount(
	characterId: string,
	accountId: string,
	conn: Conn = pool
): Promise<number> {
	const [result] = await conn.query<ResultSetHeader>(
		'DELETE FROM accounts WHERE character_id = ? AND account_id = ?',
		[characterId, accountId]
	);
	return result.affectedRows;
}
