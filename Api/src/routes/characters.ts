/**
 * @author Epyi
 */

import type { FastifyInstance, FastifyPluginAsync } from 'fastify';
import type { ZodTypeProvider } from 'fastify-type-provider-zod';
import { z } from 'zod';

import { requireBearer } from '../middleware/auth.js';
import * as accountRepo from '../repositories/accountRepository.js';
import * as characterRepo from '../repositories/characterRepository.js';
import type { CharacterRow } from '../repositories/characterRepository.js';
import * as inventoryRepo from '../repositories/inventoryRepository.js';
import * as characterService from '../services/characterService.js';
import { accountIdSchema, accountUpdateSchema } from '../schemas/account.js';
import {
	characterDetailSchema,
	characterSnapshotSchema,
	characterUpdateSchema
} from '../schemas/character.js';
import { characterIdSchema, steamIdSchema } from '../schemas/common.js';
import {
	inventorySlotUpsertSchema,
	MAX_INVENTORY_SLOT
} from '../schemas/inventory.js';

export const characterRoutes: FastifyPluginAsync = async (app) => {
	const fastify = app.withTypeProvider<ZodTypeProvider>();

	fastify.addHook('onRequest', requireBearer);

	const characterParams = z.object({
		steamId: steamIdSchema,
		characterId: characterIdSchema
	});

	const accountParams = z.object({
		steamId: steamIdSchema,
		characterId: characterIdSchema,
		accountId: accountIdSchema
	});

	const inventorySlotParams = z.object({
		steamId: steamIdSchema,
		characterId: characterIdSchema,
		slot: z.coerce.number().int().min(0).max(MAX_INVENTORY_SLOT)
	});

	fastify.get(
		'/players/:steamId/characters/:characterId',
		{
			schema: {
				params: characterParams,
				response: { 200: characterDetailSchema }
			}
		},
		async (req) => {
			const character = await loadOwnedCharacter(fastify, req.params.steamId, req.params.characterId);
			const [accounts, inventory] = await Promise.all([
				accountRepo.listForCharacter(character.id),
				inventoryRepo.listForCharacter(character.id)
			]);
			return {
				...characterRepo.rowToSummary(character),
				accounts,
				inventory
			};
		}
	);

	fastify.put(
		'/players/:steamId/characters/:characterId',
		{
			schema: {
				params: characterParams,
				body: characterUpdateSchema,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			await loadOwnedCharacter(fastify, req.params.steamId, req.params.characterId);
			if (req.body.lastPosition !== undefined) {
				await characterRepo.updatePosition(req.params.characterId, req.body.lastPosition);
			}
			return reply.status(204).send(null);
		}
	);

	fastify.delete(
		'/players/:steamId/characters/:characterId',
		{
			schema: {
				params: characterParams,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			await loadOwnedCharacter(fastify, req.params.steamId, req.params.characterId);
			const affected = await characterRepo.deleteById(req.params.characterId);
			if (affected === 0) throw fastify.httpErrors.notFound('Character not found.');
			return reply.status(204).send(null);
		}
	);

	fastify.put(
		'/players/:steamId/characters/:characterId/accounts/:accountId',
		{
			schema: {
				params: accountParams,
				body: accountUpdateSchema,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			await loadOwnedCharacter(fastify, req.params.steamId, req.params.characterId);
			await accountRepo.setAmount(req.params.characterId, req.params.accountId, req.body.amount);
			return reply.status(204).send(null);
		}
	);

	fastify.delete(
		'/players/:steamId/characters/:characterId/accounts/:accountId',
		{
			schema: {
				params: accountParams,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			await loadOwnedCharacter(fastify, req.params.steamId, req.params.characterId);
			const affected = await accountRepo.deleteAccount(req.params.characterId, req.params.accountId);
			if (affected === 0) throw fastify.httpErrors.notFound('Account not found.');
			return reply.status(204).send(null);
		}
	);

	fastify.put(
		'/players/:steamId/characters/:characterId/inventory/:slot',
		{
			schema: {
				params: inventorySlotParams,
				body: inventorySlotUpsertSchema,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			await loadOwnedCharacter(fastify, req.params.steamId, req.params.characterId);
			await inventoryRepo.upsertSlot(req.params.characterId, req.params.slot, req.body);
			return reply.status(204).send(null);
		}
	);

	fastify.delete(
		'/players/:steamId/characters/:characterId/inventory/:slot',
		{
			schema: {
				params: inventorySlotParams,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			await loadOwnedCharacter(fastify, req.params.steamId, req.params.characterId);
			const affected = await inventoryRepo.clearSlot(req.params.characterId, req.params.slot);
			if (affected === 0) throw fastify.httpErrors.notFound('Inventory slot empty.');
			return reply.status(204).send(null);
		}
	);

	// Atomic full-state save. The host posts this every 10 minutes and on
	// disconnect / character switch / admin /saveallcharacters. One MariaDB
	// transaction wraps position + vitals + every wallet + the entire
	// inventory replacement, so a partial failure keeps the previous
	// snapshot rather than half-writing a row.
	fastify.post(
		'/players/:steamId/characters/:characterId/snapshot',
		{
			schema: {
				params: characterParams,
				body: characterSnapshotSchema,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			await loadOwnedCharacter(fastify, req.params.steamId, req.params.characterId);
			await characterService.saveSnapshot(req.params.characterId, req.body);
			return reply.status(204).send(null);
		}
	);
};

/**
 * Load a character and verify it belongs to the given Steam id. Returns 404
 * for both "no such character" and "character belongs to someone else" so we
 * never leak ids that exist on other players.
 */
async function loadOwnedCharacter(
	fastify: FastifyInstance,
	steamId: string,
	characterId: string
): Promise<CharacterRow> {
	const row = await characterRepo.findById(characterId);
	if (!row || row.steam_id !== steamId) {
		throw fastify.httpErrors.notFound('Character not found.');
	}
	return row;
}
