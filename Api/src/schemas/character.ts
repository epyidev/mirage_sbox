/**
 * @author Epyi
 */

import { z } from 'zod';

import { accountEntrySchema } from './account.js';
import { characterIdSchema, positionSchema } from './common.js';
import { inventoryEntrySchema } from './inventory.js';

export const MAX_CHARACTER_SLOT = 7;

export const characterSummarySchema = z.object({
	id: characterIdSchema,
	steamId: z.string(),
	slot: z.number().int().min(0).max(MAX_CHARACTER_SLOT),
	lastPosition: positionSchema.nullable(),
	createdAt: z.string(),
	updatedAt: z.string()
});

export type CharacterSummary = z.infer<typeof characterSummarySchema>;

export const characterDetailSchema = characterSummarySchema.extend({
	accounts: z.array(accountEntrySchema),
	inventory: z.array(inventoryEntrySchema)
});

export type CharacterDetail = z.infer<typeof characterDetailSchema>;

export const characterCreateSchema = z.object({
	slot: z.number().int().min(0).max(MAX_CHARACTER_SLOT)
});

export type CharacterCreate = z.infer<typeof characterCreateSchema>;

export const characterUpdateSchema = z
	.object({
		lastPosition: positionSchema.optional()
	})
	.refine((v) => Object.keys(v).length > 0, {
		message: 'character update must include at least one field'
	});

export type CharacterUpdate = z.infer<typeof characterUpdateSchema>;
