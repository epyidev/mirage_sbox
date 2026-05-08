/**
 * @author Epyi
 */

import { z } from 'zod';

import { accountEntrySchema, accountIdSchema } from './account.js';
import { characterIdSchema, positionSchema } from './common.js';
import { inventoryEntrySchema, MAX_INVENTORY_SLOT } from './inventory.js';

export const MAX_CHARACTER_SLOT = 7;

/**
 * Vital stats persisted alongside position. Health and armour are clamped
 * to a sensible 0-1000 range so a corrupt save cannot push a character
 * into surreal numbers, but the engine usually keeps them in 0-100.
 */
export const vitalsSchema = z.object({
	health: z.number().min(0).max(1000),
	maxHealth: z.number().min(1).max(1000),
	armour: z.number().min(0).max(1000)
});

export type Vitals = z.infer<typeof vitalsSchema>;

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
	health: z.number().min(0).max(1000),
	maxHealth: z.number().min(1).max(1000),
	armour: z.number().min(0).max(1000),
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

/**
 * Atomic snapshot of every persistent piece of a character: identity stays
 * locked (it is the character's RP "self"), but everything that mutates
 * during play (position, vitals, wallets, inventory) is shipped at once
 * and applied in a single MariaDB transaction. The host calls this every
 * 10 minutes plus on disconnect / character switch / admin save.
 */
export const characterSnapshotWalletSchema = z.object({
	accountId: accountIdSchema,
	amount: z.number().int()
});

export const characterSnapshotInventorySchema = z.object({
	slot: z.number().int().min(0).max(MAX_INVENTORY_SLOT),
	itemId: z.string().min(1).max(64),
	quantity: z.number().int().positive(),
	metadata: z.record(z.unknown()).nullable().optional()
});

export const characterSnapshotSchema = z.object({
	lastPosition: positionSchema.nullable().optional(),
	vitals: vitalsSchema,
	wallets: z.array(characterSnapshotWalletSchema),
	inventory: z.array(characterSnapshotInventorySchema)
});

export type CharacterSnapshot = z.infer<typeof characterSnapshotSchema>;
