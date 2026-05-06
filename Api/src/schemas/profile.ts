/**
 * @author Epyi
 */

import { z } from 'zod';

import { positionSchema } from './common.js';

export const inventoryEntrySchema = z.object({
	itemId: z.string().min(1).max(64),
	quantity: z.number().int().nonnegative(),
	metadata: z.record(z.unknown()).nullable().optional()
});

export type InventoryEntry = z.infer<typeof inventoryEntrySchema>;

export const profileSchema = z.object({
	steamId: z.string(),
	displayName: z.string(),
	cashMoney: z.number().int(),
	bankMoney: z.number().int(),
	lastPosition: positionSchema.nullable(),
	lastSeenAt: z.string(),
	inventory: z.array(inventoryEntrySchema)
});

export type PlayerProfile = z.infer<typeof profileSchema>;

export const profileSnapshotSchema = z
	.object({
		displayName: z.string().min(1).max(64).optional(),
		cashMoney: z.number().int().optional(),
		bankMoney: z.number().int().optional(),
		lastPosition: positionSchema.optional()
	})
	.refine((v) => Object.keys(v).length > 0, {
		message: 'profile snapshot must include at least one field'
	});

export type ProfileSnapshot = z.infer<typeof profileSnapshotSchema>;
