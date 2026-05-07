/**
 * @author Epyi
 */

import { withTransaction } from '../db/pool.js';
import * as accountRepo from '../repositories/accountRepository.js';
import * as characterRepo from '../repositories/characterRepository.js';

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
