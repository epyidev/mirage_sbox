/**
 * @author Epyi
 */

import type { FastifyPluginAsync } from 'fastify';
import type { ZodTypeProvider } from 'fastify-type-provider-zod';
import { z } from 'zod';

import { requireBearer } from '../middleware/auth.js';
import * as inventoryRepo from '../repositories/inventoryRepository.js';
import * as profileRepo from '../repositories/profileRepository.js';
import { steamIdSchema } from '../schemas/common.js';
import { profileSchema, profileSnapshotSchema } from '../schemas/profile.js';

export const profileRoutes: FastifyPluginAsync = async (app) => {
	const fastify = app.withTypeProvider<ZodTypeProvider>();

	fastify.addHook('onRequest', requireBearer);

	fastify.get(
		'/profiles/:steamId',
		{
			schema: {
				params: z.object({ steamId: steamIdSchema }),
				response: { 200: profileSchema }
			}
		},
		async (req) => {
			const { steamId } = req.params;
			await profileRepo.createIfMissing(steamId);
			const player = await profileRepo.findBySteamId(steamId);
			if (!player) {
				throw fastify.httpErrors.internalServerError('Profile not found after upsert.');
			}
			const inventory = await inventoryRepo.listForPlayer(steamId);

			return {
				steamId: player.steam_id,
				displayName: player.display_name,
				cashMoney: player.cash_money,
				bankMoney: player.bank_money,
				lastPosition:
					player.last_pos_x === null
						? null
						: {
								x: player.last_pos_x,
								y: player.last_pos_y ?? 0,
								z: player.last_pos_z ?? 0,
								yaw: player.last_yaw ?? 0
							},
				lastSeenAt: player.last_seen_at.toISOString(),
				inventory
			};
		}
	);

	fastify.put(
		'/profiles/:steamId',
		{
			schema: {
				params: z.object({ steamId: steamIdSchema }),
				body: profileSnapshotSchema,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			await profileRepo.createIfMissing(req.params.steamId);
			await profileRepo.updateSnapshot(req.params.steamId, req.body);
			return reply.status(204).send();
		}
	);
};
