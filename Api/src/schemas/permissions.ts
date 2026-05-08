/**
 * @author Epyi
 */

import { z } from 'zod';

import { steamIdSchema } from './common.js';

/**
 * Group identifier. Matches the `chk_permissions_groups_id` SQL constraint:
 * lowercase letters, digits and underscores, 1 to 32 characters.
 */
export const groupIdSchema = z
	.string()
	.min(1)
	.max(32)
	.regex(
		/^[a-z0-9_]+$/,
		'groupId must be 1 to 32 characters of lowercase letters, digits or underscores'
	);

/**
 * Opaque permission string. Lower-case is the convention but not enforced, so
 * the gamemode can stay flexible. Stars are valid for wildcards (`*`,
 * `prefix.*`).
 */
export const permissionStringSchema = z
	.string()
	.min(1)
	.max(128)
	.regex(
		/^[A-Za-z0-9_.*-]+$/,
		'permission must be 1 to 128 characters of letters, digits, underscores, dots, dashes or stars'
	);

export const displayNameSchema = z.string().min(1).max(64);

export const prioritySchema = z.number().int().min(-1000).max(1000);

export const groupCreateSchema = z.object({
	id: groupIdSchema,
	displayName: displayNameSchema,
	priority: prioritySchema.default(0)
});

export type GroupCreate = z.infer<typeof groupCreateSchema>;

export const groupPatchSchema = z
	.object({
		displayName: displayNameSchema.optional(),
		priority: prioritySchema.optional()
	})
	.refine((v) => Object.keys(v).length > 0, {
		message: 'group patch must include at least one field'
	});

export type GroupPatch = z.infer<typeof groupPatchSchema>;

export const groupSummarySchema = z.object({
	id: groupIdSchema,
	displayName: displayNameSchema,
	priority: prioritySchema,
	createdAt: z.string(),
	updatedAt: z.string()
});

export type GroupSummary = z.infer<typeof groupSummarySchema>;

export const groupDetailSchema = groupSummarySchema.extend({
	permissions: z.array(permissionStringSchema)
});

export type GroupDetail = z.infer<typeof groupDetailSchema>;

export const playerPermissionsSchema = z.object({
	steamId: steamIdSchema,
	permissions: z.array(permissionStringSchema)
});

export type PlayerPermissions = z.infer<typeof playerPermissionsSchema>;

/**
 * Listing entry for `GET /permissions/players`. Every row in
 * `permissions_player_permissions` is a direct override on top of the implicit
 * `_group.default` membership, so the count is always at least one.
 */
export const playerOverrideSummarySchema = z.object({
	steamId: steamIdSchema,
	permissionCount: z.number().int().min(1)
});

export type PlayerOverrideSummary = z.infer<typeof playerOverrideSummarySchema>;
