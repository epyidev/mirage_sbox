/**
 * @author Epyi
 */

import type { FastifyPluginAsync } from 'fastify';
import type { ZodTypeProvider } from 'fastify-type-provider-zod';
import { z } from 'zod';

import { requireBearer } from '../middleware/auth.js';
import * as characterRepo from '../repositories/characterRepository.js';
import * as playerRepo from '../repositories/playerRepository.js';
import {
	characterCreateSchema,
	characterSummarySchema
} from '../schemas/character.js';
import { steamIdSchema } from '../schemas/common.js';
import { playerSchema, playerUpdateSchema } from '../schemas/player.js';
import { CharacterSlotTakenError, createCharacter } from '../services/characterService.js';

export const playerRoutes: FastifyPluginAsync = async (app) => {
	const fastify = app.withTypeProvider<ZodTypeProvider>();

	fastify.addHook('onRequest', requireBearer);

	const playerParams = z.object({ steamId: steamIdSchema });

	fastify.get(
		'/players/:steamId',
		{
			schema: {
				params: playerParams,
				response: { 200: playerSchema }
			}
		},
		async (req) => {
			const { steamId } = req.params;
			await playerRepo.createIfMissing(steamId);
			const row = await playerRepo.findBySteamId(steamId);
			if (!row) throw fastify.httpErrors.internalServerError('Player not found after upsert.');
			return playerRepo.rowToPlayer(row);
		}
	);

	fastify.put(
		'/players/:steamId',
		{
			schema: {
				params: playerParams,
				body: playerUpdateSchema,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			const { steamId } = req.params;
			await playerRepo.createIfMissing(steamId);
			if (req.body.displayName !== undefined) {
				await playerRepo.setDisplayName(steamId, req.body.displayName);
			}
			if (req.body.recordIp !== undefined) {
				await playerRepo.recordIp(steamId, req.body.recordIp);
			}
			return reply.status(204).send(null);
		}
	);

	fastify.get(
		'/players/:steamId/characters',
		{
			schema: {
				params: playerParams,
				response: { 200: z.array(characterSummarySchema) }
			}
		},
		async (req) => {
			const rows = await characterRepo.listForPlayer(req.params.steamId);
			return rows.map(characterRepo.rowToSummary);
		}
	);

	fastify.post(
		'/players/:steamId/characters',
		{
			schema: {
				params: playerParams,
				body: characterCreateSchema,
				response: { 201: characterSummarySchema }
			}
		},
		async (req, reply) => {
			const { steamId } = req.params;
			await playerRepo.createIfMissing(steamId);
			try {
				const id = await createCharacter(steamId, req.body);
				const row = await characterRepo.findById(id);
				if (!row) throw fastify.httpErrors.internalServerError('Character not found after insert.');
				return reply.status(201).send(characterRepo.rowToSummary(row));
			} catch (err) {
				if (err instanceof CharacterSlotTakenError) {
					throw fastify.httpErrors.conflict(err.message);
				}
				throw err;
			}
		}
	);
};
