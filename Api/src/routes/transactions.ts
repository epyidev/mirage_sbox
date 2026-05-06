/**
 * @author Epyi
 */

import type { FastifyPluginAsync } from 'fastify';
import type { ZodTypeProvider } from 'fastify-type-provider-zod';

import { requireBearer } from '../middleware/auth.js';
import { buyRequestSchema, buyResponseSchema } from '../schemas/transaction.js';
import { BusinessError, executeBuy } from '../services/transactionService.js';

export const transactionRoutes: FastifyPluginAsync = async (app) => {
	const fastify = app.withTypeProvider<ZodTypeProvider>();

	fastify.addHook('onRequest', requireBearer);

	fastify.post(
		'/transactions/buy',
		{
			schema: {
				body: buyRequestSchema,
				response: { 200: buyResponseSchema }
			}
		},
		async (req) => {
			try {
				return await executeBuy(req.body);
			} catch (err) {
				if (err instanceof BusinessError) {
					req.log.info({ code: err.code, details: err.details }, err.message);
					switch (err.code) {
						case 'insufficient_funds':
							throw fastify.httpErrors.paymentRequired(err.message);
						case 'player_missing':
							throw fastify.httpErrors.notFound(err.message);
						case 'transaction_replay_failed':
							throw fastify.httpErrors.conflict(err.message);
					}
				}
				throw err;
			}
		}
	);
};
