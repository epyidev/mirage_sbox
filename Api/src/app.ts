/**
 * @author Epyi
 */

import sensible from '@fastify/sensible';
import Fastify, { type FastifyInstance } from 'fastify';
import {
	serializerCompiler,
	validatorCompiler,
	type ZodTypeProvider
} from 'fastify-type-provider-zod';

import { env } from './config/env.js';
import { healthRoutes } from './routes/health.js';
import { profileRoutes } from './routes/profiles.js';
import { transactionRoutes } from './routes/transactions.js';

export async function buildApp(): Promise<FastifyInstance> {
	const app = Fastify({
		logger: {
			level: env.LOG_LEVEL
		},
		bodyLimit: 256 * 1024,
		disableRequestLogging: false,
		trustProxy: false
	}).withTypeProvider<ZodTypeProvider>();

	app.setValidatorCompiler(validatorCompiler);
	app.setSerializerCompiler(serializerCompiler);

	await app.register(sensible);

	await app.register(healthRoutes);
	await app.register(profileRoutes);
	await app.register(transactionRoutes);

	return app;
}
