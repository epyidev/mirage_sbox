/**
 * @author Epyi
 */

import { z } from 'zod';

/**
 * Address string used for IP history. Stored opaquely: the gamemode reports
 * whatever <c>Connection.Address</c> hands it (raw IPv4, IPv6, or in some
 * s&box configurations a Steam Datagram Relay endpoint), and we keep the
 * value as-is for ban-evasion spotting. We bound the length to keep the JSON
 * column well-behaved but do not enforce a strict IP shape.
 */
export const ipAddressSchema = z.string().min(1).max(128);

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

/**
 * Short numeric identifier minted by the database (auto-increment) and
 * stable across sessions. Used as the public-facing player handle in
 * staff commands ("/give 42 ammo_9 30") and rendered in the HUD so admins
 * never have to copy a Steam id around.
 */
export const playerIdSchema = z.number().int().positive();

export const playerSchema = z.object({
	id: playerIdSchema,
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
