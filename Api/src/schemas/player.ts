/**
 * @author Epyi
 */

import { z } from 'zod';

export const ipAddressSchema = z.string().ip();

/**
 * One entry in the `players.known_ips` JSON array. We keep it as an object so
 * we can record when each IP was last observed, which makes ban-evasion
 * spotting easier than a flat list of strings.
 */
export const knownIpEntrySchema = z.object({
	ip: z.string(),
	lastSeenAt: z.string()
});

export type KnownIpEntry = z.infer<typeof knownIpEntrySchema>;

export const playerSchema = z.object({
	steamId: z.string(),
	displayName: z.string(),
	knownIps: z.array(knownIpEntrySchema),
	createdAt: z.string(),
	updatedAt: z.string()
});

export type Player = z.infer<typeof playerSchema>;

export const playerUpdateSchema = z
	.object({
		displayName: z.string().min(1).max(64).optional(),
		recordIp: ipAddressSchema.optional()
	})
	.refine((v) => Object.keys(v).length > 0, {
		message: 'player update must include at least one field'
	});

export type PlayerUpdate = z.infer<typeof playerUpdateSchema>;
