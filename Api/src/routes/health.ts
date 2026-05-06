/**
 * @author Epyi
 */

import type { FastifyPluginAsync } from 'fastify';
import type { ZodTypeProvider } from 'fastify-type-provider-zod';
import { z } from 'zod';

import { pool } from '../db/pool.js';

const healthResponseSchema = z.object({
	status: z.literal('ok'),
	database: z.literal('ok'),
	uptimeSeconds: z.number()
});

export const healthRoutes: FastifyPluginAsync = async (app) => {
	const fastify = app.withTypeProvider<ZodTypeProvider>();

	fastify.get(
		'/health',
		{
			schema: {
				response: { 200: healthResponseSchema }
			}
		},
		async () => {
			await pool.query('SELECT 1');
			return {
				status: 'ok' as const,
				database: 'ok' as const,
				uptimeSeconds: Math.round(process.uptime())
			};
		}
	);
};
