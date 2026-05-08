/**
 * @author Epyi
 */

import type { FastifyPluginAsync } from 'fastify';
import type { ZodTypeProvider } from 'fastify-type-provider-zod';
import { z } from 'zod';

import { requireBearer } from '../middleware/auth.js';
import * as groupRepo from '../repositories/permissionsGroupRepository.js';
import * as playerPermRepo from '../repositories/permissionsPlayerRepository.js';
import { steamIdSchema } from '../schemas/common.js';
import {
	groupCreateSchema,
	groupDetailSchema,
	groupIdSchema,
	groupPatchSchema,
	groupSummarySchema,
	permissionStringSchema,
	playerOverrideSummarySchema,
	playerPermissionsSchema
} from '../schemas/permissions.js';

const RESERVED_GROUP_IDS = new Set(['owner', 'default']);

export const permissionsRoutes: FastifyPluginAsync = async (app) => {
	const fastify = app.withTypeProvider<ZodTypeProvider>();

	fastify.addHook('onRequest', requireBearer);

	const groupParams = z.object({ id: groupIdSchema });

	const groupPermissionParams = z.object({
		id: groupIdSchema,
		permission: permissionStringSchema
	});

	const playerParams = z.object({ steamId: steamIdSchema });

	const playerPermissionParams = z.object({
		steamId: steamIdSchema,
		permission: permissionStringSchema
	});

	fastify.get(
		'/permissions/groups',
		{
			schema: {
				response: { 200: z.array(groupDetailSchema) }
			}
		},
		async () => {
			const entries = await groupRepo.listAllWithPermissions();
			return entries.map((e) => ({
				...groupRepo.rowToSummary(e.row),
				permissions: e.permissions
			}));
		}
	);

	fastify.post(
		'/permissions/groups',
		{
			schema: {
				body: groupCreateSchema,
				response: { 201: groupSummarySchema }
			}
		},
		async (req, reply) => {
			try {
				await groupRepo.create({
					id: req.body.id,
					display_name: req.body.displayName,
					priority: req.body.priority
				});
			} catch (err) {
				if (isDuplicateEntry(err)) {
					throw fastify.httpErrors.conflict(`Group '${req.body.id}' already exists.`);
				}
				throw err;
			}
			const row = await groupRepo.findById(req.body.id);
			if (!row) throw fastify.httpErrors.internalServerError('Group not found after insert.');
			return reply.status(201).send(groupRepo.rowToSummary(row));
		}
	);

	fastify.get(
		'/permissions/groups/:id',
		{
			schema: {
				params: groupParams,
				response: { 200: groupDetailSchema }
			}
		},
		async (req) => {
			const row = await groupRepo.findById(req.params.id);
			if (!row) throw fastify.httpErrors.notFound('Group not found.');
			const permissions = await groupRepo.listPermissions(req.params.id);
			return {
				...groupRepo.rowToSummary(row),
				permissions
			};
		}
	);

	fastify.patch(
		'/permissions/groups/:id',
		{
			schema: {
				params: groupParams,
				body: groupPatchSchema,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			const affected = await groupRepo.patch(req.params.id, {
				display_name: req.body.displayName,
				priority: req.body.priority
			});
			if (affected === 0) {
				const row = await groupRepo.findById(req.params.id);
				if (!row) throw fastify.httpErrors.notFound('Group not found.');
			}
			return reply.status(204).send(null);
		}
	);

	fastify.delete(
		'/permissions/groups/:id',
		{
			schema: {
				params: groupParams,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			if (RESERVED_GROUP_IDS.has(req.params.id)) {
				throw fastify.httpErrors.conflict('cannot delete reserved group');
			}
			const affected = await groupRepo.deleteById(req.params.id);
			if (affected === 0) throw fastify.httpErrors.notFound('Group not found.');
			return reply.status(204).send(null);
		}
	);

	fastify.put(
		'/permissions/groups/:id/permissions/:permission',
		{
			schema: {
				params: groupPermissionParams,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			const row = await groupRepo.findById(req.params.id);
			if (!row) throw fastify.httpErrors.notFound('Group not found.');
			await groupRepo.addPermission(req.params.id, req.params.permission);
			return reply.status(204).send(null);
		}
	);

	fastify.delete(
		'/permissions/groups/:id/permissions/:permission',
		{
			schema: {
				params: groupPermissionParams,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			const affected = await groupRepo.removePermission(
				req.params.id,
				req.params.permission
			);
			if (affected === 0) throw fastify.httpErrors.notFound('Permission not found on group.');
			return reply.status(204).send(null);
		}
	);

	fastify.get(
		'/permissions/players',
		{
			schema: {
				response: { 200: z.array(playerOverrideSummarySchema) }
			}
		},
		async () => {
			const rows = await playerPermRepo.listOverrides();
			return rows.map((r) => ({
				steamId: r.steam_id,
				permissionCount: r.count
			}));
		}
	);

	fastify.get(
		'/permissions/players/:steamId',
		{
			schema: {
				params: playerParams,
				response: { 200: playerPermissionsSchema }
			}
		},
		async (req) => {
			const permissions = await playerPermRepo.listForPlayer(req.params.steamId);
			return {
				steamId: req.params.steamId,
				permissions
			};
		}
	);

	fastify.put(
		'/permissions/players/:steamId/permissions/:permission',
		{
			schema: {
				params: playerPermissionParams,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			await playerPermRepo.addPermission(req.params.steamId, req.params.permission);
			return reply.status(204).send(null);
		}
	);

	fastify.delete(
		'/permissions/players/:steamId/permissions/:permission',
		{
			schema: {
				params: playerPermissionParams,
				response: { 204: z.null() }
			}
		},
		async (req, reply) => {
			const affected = await playerPermRepo.removePermission(
				req.params.steamId,
				req.params.permission
			);
			if (affected === 0) throw fastify.httpErrors.notFound('Permission not found on player.');
			return reply.status(204).send(null);
		}
	);
};

function isDuplicateEntry(err: unknown): boolean {
	return typeof err === 'object' && err !== null && 'code' in err && (err as { code: unknown }).code === 'ER_DUP_ENTRY';
}
