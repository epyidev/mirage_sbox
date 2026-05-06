/**
 * @author Epyi
 */

import { z } from 'zod';

/**
 * SteamID64 wrapped as a JSON string. We never put it in a JS number because
 * the value exceeds the 53-bit safe integer range.
 */
export const steamIdSchema = z
	.string()
	.regex(/^\d{17}$/, 'steamId must be a 17-digit SteamID64 string');

export const transactionIdSchema = z.string().uuid('transactionId must be a UUID string');

export const positionSchema = z.object({
	x: z.number().finite(),
	y: z.number().finite(),
	z: z.number().finite(),
	yaw: z.number().finite()
});

export type Position = z.infer<typeof positionSchema>;
