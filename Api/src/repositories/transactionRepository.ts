/**
 * @author Epyi
 */

import type { PoolConnection, RowDataPacket } from 'mysql2/promise';

export interface TransactionRow {
	id: string;
	steam_id: string;
	type: string;
	amount: number;
	status: string;
	context: Record<string, unknown> | null;
	created_at: Date;
}

export async function findById(
	conn: PoolConnection,
	id: string
): Promise<TransactionRow | null> {
	const [rows] = await conn.query<RowDataPacket[]>(
		'SELECT * FROM transactions WHERE id = ? LIMIT 1',
		[id]
	);
	return (rows[0] as TransactionRow | undefined) ?? null;
}

export interface TransactionInsert {
	id: string;
	steamId: string;
	type: string;
	amount: number;
	status: string;
	context: Record<string, unknown> | null;
}

export async function record(conn: PoolConnection, row: TransactionInsert): Promise<void> {
	await conn.query(
		`INSERT INTO transactions (id, steam_id, type, amount, status, context)
		 VALUES (?, ?, ?, ?, ?, ?)`,
		[
			row.id,
			row.steamId,
			row.type,
			row.amount,
			row.status,
			row.context ? JSON.stringify(row.context) : null
		]
	);
}
