/**
 * @author Epyi
 */

import { z } from 'zod';

/**
 * Each character holds one row per wallet ("cash", "bank", and any new
 * wallet introduced later). The id is a free-form short string so gameplay
 * code can add wallets without a schema change.
 */
export const accountIdSchema = z
	.string()
	.min(1)
	.max(64)
	.regex(/^[a-z0-9_]+$/, 'accountId must be lowercase alphanumeric with underscores');

export const accountEntrySchema = z.object({
	accountId: accountIdSchema,
	amount: z.number().int(),
	updatedAt: z.string()
});

export type AccountEntry = z.infer<typeof accountEntrySchema>;

export const accountUpdateSchema = z.object({
	amount: z.number().int()
});

export type AccountUpdate = z.infer<typeof accountUpdateSchema>;
