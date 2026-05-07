/**
 * @author Epyi
 */

import { z } from 'zod';

export const MAX_INVENTORY_SLOT = 4095;

export const inventoryEntrySchema = z.object({
	slot: z.number().int().min(0).max(MAX_INVENTORY_SLOT),
	itemId: z.string().min(1).max(64),
	quantity: z.number().int().nonnegative(),
	metadata: z.record(z.unknown()).nullable().optional()
});

export type InventoryEntry = z.infer<typeof inventoryEntrySchema>;

export const inventorySlotUpsertSchema = z.object({
	itemId: z.string().min(1).max(64),
	quantity: z.number().int().positive(),
	metadata: z.record(z.unknown()).nullable().optional()
});

export type InventorySlotUpsert = z.infer<typeof inventorySlotUpsertSchema>;
