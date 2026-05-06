-- @author Epyi
-- Initial schema for the Mirage backend: players, inventory, transactions audit log.

CREATE TABLE IF NOT EXISTS players (
	steam_id        BIGINT UNSIGNED NOT NULL,
	display_name    VARCHAR(64)     NOT NULL DEFAULT '',
	cash_money      INT             NOT NULL DEFAULT 0,
	bank_money      INT             NOT NULL DEFAULT 0,
	last_pos_x      FLOAT           NULL,
	last_pos_y      FLOAT           NULL,
	last_pos_z      FLOAT           NULL,
	last_yaw        FLOAT           NULL,
	last_seen_at    DATETIME        NOT NULL DEFAULT CURRENT_TIMESTAMP,
	created_at      DATETIME        NOT NULL DEFAULT CURRENT_TIMESTAMP,
	updated_at      DATETIME        NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY (steam_id),
	INDEX idx_players_last_seen (last_seen_at)
) ENGINE = InnoDB
  DEFAULT CHARSET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS player_inventory (
	steam_id    BIGINT UNSIGNED NOT NULL,
	item_id     VARCHAR(64)     NOT NULL,
	quantity    INT             NOT NULL,
	metadata    JSON            NULL,
	updated_at  DATETIME        NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY (steam_id, item_id),
	CONSTRAINT fk_inventory_player
		FOREIGN KEY (steam_id) REFERENCES players (steam_id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT chk_inventory_qty CHECK (quantity >= 0)
) ENGINE = InnoDB
  DEFAULT CHARSET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS transactions (
	id           CHAR(36)         NOT NULL,
	steam_id     BIGINT UNSIGNED  NOT NULL,
	type         VARCHAR(32)      NOT NULL,
	amount       INT              NOT NULL,
	status       VARCHAR(16)      NOT NULL,
	context      JSON             NULL,
	created_at   DATETIME         NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (id),
	INDEX idx_transactions_player_time (steam_id, created_at),
	INDEX idx_transactions_status_time (status, created_at)
) ENGINE = InnoDB
  DEFAULT CHARSET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;
