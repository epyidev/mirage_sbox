/**
 * @author Epyi
 */

import { z } from 'zod';

import { steamIdSchema, transactionIdSchema } from './common.js';

export const buyRequestSchema = z.object({
	transactionId: transactionIdSchema,
	steamId: steamIdSchema,
	shopId: z.string().min(1).max(64),
	items: z
		.array(
			z.object({
				itemId: z.string().min(1).max(64),
				quantity: z.number().int().positive().max(10_000)
			})
		)
		.min(1)
		.max(64),
	expectedTotal: z.number().int().nonnegative(),
	currency: z.enum(['cash', 'bank']).default('cash')
});

export type BuyRequest = z.infer<typeof buyRequestSchema>;

export const buyResponseSchema = z.object({
	transactionId: transactionIdSchema,
	status: z.enum(['committed', 'replayed']),
	debited: z.number().int().nonnegative(),
	currency: z.enum(['cash', 'bank']),
	newBalance: z.number().int(),
	addedItems: z.array(
		z.object({
			itemId: z.string(),
			quantity: z.number().int().positive()
		})
	)
});

export type BuyResponse = z.infer<typeof buyResponseSchema>;
