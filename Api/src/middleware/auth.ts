/**
 * @author Epyi
 */

import { Buffer } from 'node:buffer';
import { timingSafeEqual } from 'node:crypto';

import type { FastifyRequest } from 'fastify';

import { env } from '../config/env.js';

const expected = Buffer.from(env.API_BEARER_TOKEN, 'utf8');

function constantTimeEqual(a: Buffer, b: Buffer): boolean {
	if (a.length !== b.length) return false;
	return timingSafeEqual(a, b);
}

/**
 * Fastify `onRequest` hook that rejects any call without a valid Bearer token.
 * Wire on a route plugin: `fastify.addHook('onRequest', requireBearer);`.
 */
export async function requireBearer(req: FastifyRequest): Promise<void> {
	const header = req.headers.authorization;
	if (!header || !header.startsWith('Bearer ')) {
		throw req.server.httpErrors.unauthorized('Missing or malformed Authorization header.');
	}
	const provided = Buffer.from(header.slice('Bearer '.length).trim(), 'utf8');
	if (!constantTimeEqual(provided, expected)) {
		throw req.server.httpErrors.unauthorized('Invalid bearer token.');
	}
}
