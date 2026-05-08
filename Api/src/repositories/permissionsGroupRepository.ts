/**
 * @author Epyi
 */

import type { Pool, PoolConnection, ResultSetHeader, RowDataPacket } from 'mysql2/promise';

import { pool } from '../db/pool.js';
import type { GroupSummary } from '../schemas/permissions.js';

export interface GroupRow {
	id: string;
	display_name: string;
	priority: number;
	created_at: Date;
	updated_at: Date;
}

type Conn = Pool | PoolConnection;

export async function listAll(conn: Conn = pool): Promise<GroupRow[]> {
	const [rows] = await conn.query<RowDataPacket[]>(
		'SELECT * FROM permissions_groups ORDER BY priority DESC, id ASC'
	);
	return rows as GroupRow[];
}

export async function findById(id: string, conn: Conn = pool): Promise<GroupRow | null> {
	const [rows] = await conn.query<RowDataPacket[]>(
		'SELECT * FROM permissions_groups WHERE id = ? LIMIT 1',
		[id]
	);
	return (rows[0] as GroupRow | undefined) ?? null;
}

export async function create(
	payload: { id: string; display_name: string; priority: number },
	conn: Conn = pool
): Promise<void> {
	await conn.query<ResultSetHeader>(
		'INSERT INTO permissions_groups (id, display_name, priority) VALUES (?, ?, ?)',
		[payload.id, payload.display_name, payload.priority]
	);
}

/**
 * Build an UPDATE that only touches the columns supplied in `patch`. Returns
 * the number of rows affected so the caller can map an empty result to 404.
 */
export async function patch(
	id: string,
	patch: { display_name?: string; priority?: number },
	conn: Conn = pool
): Promise<number> {
	const sets: string[] = [];
	const params: unknown[] = [];
	if (patch.display_name !== undefined) {
		sets.push('display_name = ?');
		params.push(patch.display_name);
	}
	if (patch.priority !== undefined) {
		sets.push('priority = ?');
		params.push(patch.priority);
	}
	if (sets.length === 0) return 0;
	params.push(id);
	const [result] = await conn.query<ResultSetHeader>(
		`UPDATE permissions_groups SET ${sets.join(', ')} WHERE id = ?`,
		params
	);
	return result.affectedRows;
}

export async function deleteById(id: string, conn: Conn = pool): Promise<number> {
	const [result] = await conn.query<ResultSetHeader>(
		'DELETE FROM permissions_groups WHERE id = ?',
		[id]
	);
	return result.affectedRows;
}

export async function listPermissions(
	groupId: string,
	conn: Conn = pool
): Promise<string[]> {
	const [rows] = await conn.query<RowDataPacket[]>(
		`SELECT permission FROM permissions_group_permissions
		  WHERE group_id = ?
		  ORDER BY permission ASC`,
		[groupId]
	);
	return rows.map((r) => String(r['permission']));
}

export async function addPermission(
	groupId: string,
	permission: string,
	conn: Conn = pool
): Promise<void> {
	await conn.query<ResultSetHeader>(
		'INSERT IGNORE INTO permissions_group_permissions (group_id, permission) VALUES (?, ?)',
		[groupId, permission]
	);
}

export async function removePermission(
	groupId: string,
	permission: string,
	conn: Conn = pool
): Promise<number> {
	const [result] = await conn.query<ResultSetHeader>(
		'DELETE FROM permissions_group_permissions WHERE group_id = ? AND permission = ?',
		[groupId, permission]
	);
	return result.affectedRows;
}

/**
 * Load every group together with its permission list. Implemented as two
 * queries instead of a JOIN: the JOIN would multiply rows by permission count,
 * and stitching the result client-side is both clearer and faster for the
 * sizes we expect.
 */
export async function listAllWithPermissions(
	conn: Conn = pool
): Promise<{ row: GroupRow; permissions: string[] }[]> {
	const groups = await listAll(conn);
	const [permRows] = await conn.query<RowDataPacket[]>(
		`SELECT group_id, permission FROM permissions_group_permissions
		  ORDER BY group_id ASC, permission ASC`
	);
	const byGroup = new Map<string, string[]>();
	for (const r of permRows) {
		const gid = String(r['group_id']);
		const perm = String(r['permission']);
		const list = byGroup.get(gid);
		if (list) {
			list.push(perm);
		} else {
			byGroup.set(gid, [perm]);
		}
	}
	return groups.map((row) => ({
		row,
		permissions: byGroup.get(row.id) ?? []
	}));
}

export function rowToSummary(row: GroupRow): GroupSummary {
	return {
		id: row.id,
		displayName: row.display_name,
		priority: row.priority,
		createdAt: row.created_at.toISOString(),
		updatedAt: row.updated_at.toISOString()
	};
}
