/**
 * @author Epyi
 */

import type { Pool, PoolConnection, ResultSetHeader, RowDataPacket } from 'mysql2/promise';

import { pool, withTransaction } from '../db/pool.js';
import type { KnownIpEntry, Player } from '../schemas/player.js';

export interface PlayerRow {
	steam_id: string;
	display_name: string;
	known_ips: KnownIpEntry[];
	created_at: Date;
	updated_at: Date;
}

type Conn = Pool | PoolConnection;

export async function findBySteamId(steamId: string, conn: Conn = pool): Promise<PlayerRow | null> {
	const [rows] = await conn.query<RowDataPacket[]>(
		'SELECT * FROM players WHERE steam_id = ? LIMIT 1',
		[steamId]
	);
	const row = rows[0] as PlayerRow | undefined;
	if (!row) return null;
	return { ...row, known_ips: parseKnownIps(row.known_ips) };
}

export async function createIfMissing(steamId: string, conn: Conn = pool): Promise<void> {
	await conn.query<ResultSetHeader>(
		'INSERT IGNORE INTO players (steam_id) VALUES (?)',
		[steamId]
	);
}

export async function setDisplayName(
	steamId: string,
	displayName: string,
	conn: Conn = pool
): Promise<void> {
	await conn.query<ResultSetHeader>(
		'UPDATE players SET display_name = ? WHERE steam_id = ?',
		[displayName, steamId]
	);
}

/**
 * Append `ip` to `known_ips` with the current timestamp. If the IP already
 * appears in the list, refresh its `lastSeenAt` instead of pushing a duplicate.
 * Wrapped in a transaction with `SELECT ... FOR UPDATE` so concurrent calls on
 * the same player serialise correctly.
 */
export async function recordIp(steamId: string, ip: string): Promise<void> {
	await withTransaction(async (conn) => {
		const [rows] = await conn.query<RowDataPacket[]>(
			'SELECT known_ips FROM players WHERE steam_id = ? FOR UPDATE',
			[steamId]
		);
		const row = rows[0];
		if (!row) return;

		const current = parseKnownIps(row['known_ips']);
		const now = new Date().toISOString();
		const idx = current.findIndex((e) => e.ip === ip);
		if (idx >= 0) {
			current[idx] = { ip, lastSeenAt: now };
		} else {
			current.push({ ip, lastSeenAt: now });
		}

		await conn.query<ResultSetHeader>(
			'UPDATE players SET known_ips = ? WHERE steam_id = ?',
			[JSON.stringify(current), steamId]
		);
	});
}

export function rowToPlayer(row: PlayerRow): Player {
	return {
		steamId: row.steam_id,
		displayName: row.display_name,
		knownIps: row.known_ips,
		createdAt: row.created_at.toISOString(),
		updatedAt: row.updated_at.toISOString()
	};
}

/**
 * mysql2 v3 normally returns JSON columns pre-parsed, but a few driver paths
 * (older versions, replication, weird collations) hand back the raw string.
 * Be defensive here so the rest of the code can trust the value is an array.
 */
function parseKnownIps(value: unknown): KnownIpEntry[] {
	let parsed: unknown = value;
	if (typeof parsed === 'string') {
		try {
			parsed = JSON.parse(parsed);
		} catch {
			return [];
		}
	}
	if (!Array.isArray(parsed)) return [];
	const out: KnownIpEntry[] = [];
	for (const entry of parsed) {
		if (
			entry &&
			typeof entry === 'object' &&
			typeof (entry as { ip?: unknown }).ip === 'string' &&
			typeof (entry as { lastSeenAt?: unknown }).lastSeenAt === 'string'
		) {
			out.push({
				ip: (entry as { ip: string }).ip,
				lastSeenAt: (entry as { lastSeenAt: string }).lastSeenAt
			});
		}
	}
	return out;
}
