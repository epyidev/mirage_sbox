/**
 * @author Epyi
 */

import { withTransaction } from '../db/pool.js';
import * as inventoryRepo from '../repositories/inventoryRepository.js';
import * as profileRepo from '../repositories/profileRepository.js';
import * as transactionRepo from '../repositories/transactionRepository.js';
import type { BuyRequest, BuyResponse } from '../schemas/transaction.js';

/**
 * A `BusinessError` is a controlled rejection from the service layer that the
 * route layer maps to a meaningful HTTP status (402, 404, 409, etc.). Anything
 * not wrapped here surfaces as a 500.
 */
export class BusinessError extends Error {
	public constructor(
		public readonly code: BusinessErrorCode,
		message: string,
		public readonly details?: Record<string, unknown>
	) {
		super(message);
		this.name = 'BusinessError';
	}
}

export type BusinessErrorCode =
	| 'insufficient_funds'
	| 'player_missing'
	| 'transaction_replay_failed';

interface BuyAuditContext extends Record<string, unknown> {
	shopId: string;
	expectedTotal: number;
	totalQuantity: number;
	items: BuyRequest['items'];
}

export async function executeBuy(req: BuyRequest): Promise<BuyResponse> {
	const totalQuantity = req.items.reduce((acc, it) => acc + it.quantity, 0);
	const auditContext: BuyAuditContext = {
		shopId: req.shopId,
		expectedTotal: req.expectedTotal,
		totalQuantity,
		items: req.items
	};

	return withTransaction(async (conn) => {
		// Idempotency: a replay with the same transactionId returns the recorded outcome.
		const existing = await transactionRepo.findById(conn, req.transactionId);
		if (existing) {
			if (existing.status !== 'committed') {
				throw new BusinessError(
					'transaction_replay_failed',
					`Transaction ${req.transactionId} previously failed and cannot be retried.`,
					{ previousStatus: existing.status }
				);
			}
			const player = await profileRepo.findBySteamId(req.steamId, conn);
			if (!player) {
				throw new BusinessError('player_missing', 'Player vanished between calls.');
			}
			return {
				transactionId: req.transactionId,
				status: 'replayed',
				debited: existing.amount,
				currency: req.currency,
				newBalance: req.currency === 'cash' ? player.cash_money : player.bank_money,
				addedItems: req.items.map((it) => ({ itemId: it.itemId, quantity: it.quantity }))
			};
		}

		const player = await profileRepo.findBySteamIdForUpdate(conn, req.steamId);
		if (!player) {
			throw new BusinessError('player_missing', `Unknown player ${req.steamId}.`);
		}

		const balance = req.currency === 'cash' ? player.cash_money : player.bank_money;
		const total = req.expectedTotal;

		if (balance < total) {
			await transactionRepo.record(conn, {
				id: req.transactionId,
				steamId: req.steamId,
				type: 'buy',
				amount: total,
				status: 'rejected_funds',
				context: auditContext
			});
			throw new BusinessError(
				'insufficient_funds',
				`Player has ${balance}, needed ${total}.`,
				{ have: balance, need: total }
			);
		}

		await profileRepo.debit(conn, req.steamId, req.currency, total);
		for (const item of req.items) {
			await inventoryRepo.addItem(conn, req.steamId, item.itemId, item.quantity);
		}
		await transactionRepo.record(conn, {
			id: req.transactionId,
			steamId: req.steamId,
			type: 'buy',
			amount: total,
			status: 'committed',
			context: auditContext
		});

		return {
			transactionId: req.transactionId,
			status: 'committed',
			debited: total,
			currency: req.currency,
			newBalance: balance - total,
			addedItems: req.items.map((it) => ({ itemId: it.itemId, quantity: it.quantity }))
		};
	});
}
