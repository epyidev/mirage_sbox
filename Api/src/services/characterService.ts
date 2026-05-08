/**
 * @author Epyi
 */

import { withTransaction } from '../db/pool.js';
import * as accountRepo from '../repositories/accountRepository.js';
import * as characterRepo from '../repositories/characterRepository.js';
import * as inventoryRepo from '../repositories/inventoryRepository.js';
import type { CharacterSnapshot } from '../schemas/character.js';

export class CharacterSlotTakenError extends Error {
	public constructor(public readonly steamId: string, public readonly slot: number) {
		super(`Slot ${slot} already taken on player ${steamId}.`);
		this.name = 'CharacterSlotTakenError';
	}
}

/**
 * Create a character row plus its default wallet rows in a single SQL
 * transaction. Returns the new auto-incremented character id as a string.
 */
export async function createCharacter(
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
	try {
		return await withTransaction(async (conn) => {
			const id = await characterRepo.create(conn, steamId, payload);
			await accountRepo.seedDefaults(conn, id);
			return id;
		});
	} catch (err) {
		if (isDuplicateEntry(err)) {
			throw new CharacterSlotTakenError(steamId, payload.slot);
		}
		throw err;
	}
}

function isDuplicateEntry(err: unknown): boolean {
	return (
		typeof err === 'object' &&
		err !== null &&
		'code' in err &&
		(err as { code: unknown }).code === 'ER_DUP_ENTRY'
	);
}

/**
 * Atomically persist every mutable piece of a character: position +
 * vitals, every wallet, the entire inventory. The host calls this every
 * 10 minutes for active characters and on disconnect / character-switch
 * / admin save. Runs in one MariaDB transaction so a partial failure
 * leaves the previous good state in place rather than a half-written
 * row.
 */
export async function saveSnapshot(
	characterId: string,
	snapshot: CharacterSnapshot
): Promise<void> {
	await withTransaction(async (conn) => {
		await characterRepo.updateState(
			characterId,
			{
				position: snapshot.lastPosition ?? null,
				health: snapshot.vitals.health,
				maxHealth: snapshot.vitals.maxHealth,
				armour: snapshot.vitals.armour
			},
			conn
		);
		for (const wallet of snapshot.wallets) {
			await accountRepo.setAmount(characterId, wallet.accountId, wallet.amount, conn);
		}
		await inventoryRepo.replaceAll(characterId, snapshot.inventory, conn);
	});
}
