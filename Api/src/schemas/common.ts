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

/**
 * Auto-incrementing character id. The pool is configured with
 * `bigNumberStrings: true`, so the driver returns BIGINT columns as strings.
 * We keep the value as a string end-to-end so it round-trips safely past 2^53.
 */
export const characterIdSchema = z
	.string()
	.regex(/^\d+$/, 'characterId must be a positive integer string');

export const positionSchema = z.object({
	x: z.number().finite(),
	y: z.number().finite(),
	z: z.number().finite(),
	yaw: z.number().finite()
});

export type Position = z.infer<typeof positionSchema>;
