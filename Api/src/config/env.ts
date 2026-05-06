/**
 * @author Epyi
 */

import { config as loadDotenv } from 'dotenv';
import { z } from 'zod';

loadDotenv();

const envSchema = z.object({
	NODE_ENV: z.enum(['development', 'production', 'test']).default('development'),
	HOST: z.string().min(1).default('127.0.0.1'),
	PORT: z.coerce.number().int().positive().default(8080),
	LOG_LEVEL: z
		.enum(['fatal', 'error', 'warn', 'info', 'debug', 'trace', 'silent'])
		.default('info'),

	DATABASE_HOST: z.string().min(1),
	DATABASE_PORT: z.coerce.number().int().positive().default(3306),
	DATABASE_USER: z.string().min(1),
	DATABASE_PASSWORD: z.string(),
	DATABASE_NAME: z.string().min(1),
	DATABASE_CONNECTION_LIMIT: z.coerce.number().int().positive().default(10),

	API_BEARER_TOKEN: z
		.string()
		.min(32, 'API_BEARER_TOKEN must be at least 32 characters long')
});

export type Env = z.infer<typeof envSchema>;

const parsed = envSchema.safeParse(process.env);

if (!parsed.success) {
	console.error('Invalid environment configuration:');
	for (const issue of parsed.error.issues) {
		const path = issue.path.join('.') || '(root)';
		console.error(`  ${path}: ${issue.message}`);
	}
	process.exit(1);
}

export const env: Env = parsed.data;
