/**
 * @author Epyi
 */

import { z } from 'zod';

import { accountEntrySchema } from './account.js';
import { characterIdSchema, positionSchema } from './common.js';
import { inventoryEntrySchema } from './inventory.js';

export const MAX_CHARACTER_SLOT = 7;

export const genderSchema = z.enum(['m', 'f']);

export const birthDateSchema = z
	.string()
	.regex(/^\d{4}-\d{2}-\d{2}$/, 'birthDate must be ISO date YYYY-MM-DD');

export const characterIdentitySchema = z.object({
	firstName: z.string().min(1).max(32),
	lastName: z.string().min(1).max(32),
	birthDate: birthDateSchema,
	heightCm: z.number().int().min(50).max(272),
	gender: genderSchema
});

export const characterSummarySchema = z.object({
	id: characterIdSchema,
	steamId: z.string(),
	slot: z.number().int().min(0).max(MAX_CHARACTER_SLOT),
	firstName: z.string().min(1).max(32),
	lastName: z.string().min(1).max(32),
	birthDate: birthDateSchema,
	heightCm: z.number().int().min(50).max(272),
	gender: genderSchema,
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

export const characterCreateSchema = characterIdentitySchema.extend({
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
