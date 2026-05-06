/**
 * @author Epyi
 */

import { buildApp } from './app.js';
import { env } from './config/env.js';
import { shutdownPool } from './db/pool.js';

async function main(): Promise<void> {
	const app = await buildApp();

	const close = async (signal: NodeJS.Signals): Promise<void> => {
		app.log.info({ signal }, 'Shutting down.');
		try {
			await app.close();
			await shutdownPool();
		} catch (err) {
			app.log.error({ err }, 'Error during shutdown.');
			process.exit(1);
		}
		process.exit(0);
	};

	process.once('SIGINT', close);
	process.once('SIGTERM', close);

	await app.listen({ host: env.HOST, port: env.PORT });
}

main().catch((err: unknown) => {
	console.error('Fatal startup error:', err);
	process.exit(1);
});
