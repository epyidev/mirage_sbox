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
import { characterRoutes } from './routes/characters.js';
import { healthRoutes } from './routes/health.js';
import { permissionsRoutes } from './routes/permissions.js';
import { playerRoutes } from './routes/players.js';

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
	await app.register(playerRoutes);
	await app.register(characterRoutes);
	await app.register(permissionsRoutes);

	return app;
}
