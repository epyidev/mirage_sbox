/**
 * @author Epyi
 */

import type { Pool, PoolConnection, ResultSetHeader, RowDataPacket } from 'mysql2/promise';

import { pool } from '../db/pool.js';
import type { CharacterSummary } from '../schemas/character.js';

export interface CharacterRow {
	id: string;
	steam_id: string;
	slot: number;
	first_name: string;
	last_name: string;
	birth_date: Date | string;
	height_cm: number;
	gender: 'm' | 'f';
	last_pos_x: number | null;
	last_pos_y: number | null;
	last_pos_z: number | null;
	last_yaw: number | null;
	health: number;
	max_health: number;
	armour: number;
	created_at: Date;
	updated_at: Date;
}

type Conn = Pool | PoolConnection;

export async function findById(id: string, conn: Conn = pool): Promise<CharacterRow | null> {
	const [rows] = await conn.query<RowDataPacket[]>(
		'SELECT * FROM characters WHERE id = ? LIMIT 1',
		[id]
	);
	return (rows[0] as CharacterRow | undefined) ?? null;
}

export async function listForPlayer(
	steamId: string,
	conn: Conn = pool
): Promise<CharacterRow[]> {
	const [rows] = await conn.query<RowDataPacket[]>(
		'SELECT * FROM characters WHERE steam_id = ? ORDER BY slot ASC',
		[steamId]
	);
	return rows as CharacterRow[];
}

export async function create(
	conn: PoolConnection,
	steamId: string,
	payload: {
		slot: number;
		firstName: string;
		lastName: string;
		birthDate: string;
		heightCm: number;
		gender: 'm' | 'f';
	}
): Promise<string> {
	const [result] = await conn.query<ResultSetHeader>(
		`INSERT INTO characters (steam_id, slot, first_name, last_name, birth_date, height_cm, gender)
		 VALUES (?, ?, ?, ?, ?, ?, ?)`,
		[
			steamId,
			payload.slot,
			payload.firstName,
			payload.lastName,
			payload.birthDate,
			payload.heightCm,
			payload.gender
		]
	);
	return String(result.insertId);
}

export async function updatePosition(
	id: string,
	pos: { x: number; y: number; z: number; yaw: number },
	conn: Conn = pool
): Promise<number> {
	const [result] = await conn.query<ResultSetHeader>(
		`UPDATE characters
		    SET last_pos_x = ?, last_pos_y = ?, last_pos_z = ?, last_yaw = ?
		  WHERE id = ?`,
		[pos.x, pos.y, pos.z, pos.yaw, id]
	);
	return result.affectedRows;
}

/**
 * Persist position + vitals together. Used by the snapshot transaction so
 * a single UPDATE writes everything that lives on the character row.
 * Position is optional: a snapshot for a player who is still in limbo
 * (e.g. dead with no respawn yet) sends vitals only.
 */
export async function updateState(
	id: string,
	state: {
		position?: { x: number; y: number; z: number; yaw: number } | null;
		health: number;
		maxHealth: number;
		armour: number;
	},
	conn: Conn = pool
): Promise<number> {
	if (state.position) {
		const [result] = await conn.query<ResultSetHeader>(
			`UPDATE characters
			    SET last_pos_x = ?, last_pos_y = ?, last_pos_z = ?, last_yaw = ?,
			        health = ?, max_health = ?, armour = ?
			  WHERE id = ?`,
			[
				state.position.x,
				state.position.y,
				state.position.z,
				state.position.yaw,
				state.health,
				state.maxHealth,
				state.armour,
				id
			]
		);
		return result.affectedRows;
	}
	const [result] = await conn.query<ResultSetHeader>(
		`UPDATE characters
		    SET health = ?, max_health = ?, armour = ?
		  WHERE id = ?`,
		[state.health, state.maxHealth, state.armour, id]
	);
	return result.affectedRows;
}

export async function deleteById(id: string, conn: Conn = pool): Promise<number> {
	const [result] = await conn.query<ResultSetHeader>(
		'DELETE FROM characters WHERE id = ?',
		[id]
	);
	return result.affectedRows;
}

export function rowToSummary(row: CharacterRow): CharacterSummary {
	return {
		id: row.id,
		steamId: row.steam_id,
		slot: row.slot,
		firstName: row.first_name,
		lastName: row.last_name,
		birthDate:
			row.birth_date instanceof Date
				? row.birth_date.toISOString().slice(0, 10)
				: row.birth_date,
		heightCm: row.height_cm,
		gender: row.gender,
		lastPosition:
			row.last_pos_x === null
				? null
				: {
						x: row.last_pos_x,
						y: row.last_pos_y ?? 0,
						z: row.last_pos_z ?? 0,
						yaw: row.last_yaw ?? 0
					},
		health: row.health,
		maxHealth: row.max_health,
		armour: row.armour,
		createdAt: row.created_at.toISOString(),
		updatedAt: row.updated_at.toISOString()
	};
}
