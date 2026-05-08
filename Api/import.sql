-- @author Epyi
-- Full schema for the Mirage backend.
--
-- The model splits OOC and IC state on purpose:
--   * `players` is OOC: one row per Steam account, identity and IP history.
--   * `characters` is IC: one row per RP character, owned by a player via
--     `steam_id` and indexed by a `slot`. Holds RP identity (first name, last
--     name, birth date, height, gender) plus last known position.
--   * `accounts` and `character_inventory` hang off a character, never directly
--     off a player. Money and items belong to the character, not the account.
--
-- Import once into an empty database, then start the API.

CREATE TABLE IF NOT EXISTS players (
	steam_id        BIGINT UNSIGNED NOT NULL,
	display_name    VARCHAR(64)     NOT NULL DEFAULT '',
	known_ips       JSON            NOT NULL DEFAULT (JSON_ARRAY()),
	created_at      DATETIME        NOT NULL DEFAULT CURRENT_TIMESTAMP,
	updated_at      DATETIME        NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY (steam_id),
	CONSTRAINT chk_players_known_ips_array CHECK (JSON_TYPE(known_ips) = 'ARRAY')
) ENGINE = InnoDB
  DEFAULT CHARSET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS characters (
	id              BIGINT UNSIGNED  NOT NULL AUTO_INCREMENT,
	steam_id        BIGINT UNSIGNED  NOT NULL,
	slot            TINYINT UNSIGNED NOT NULL,
	first_name      VARCHAR(32)      NOT NULL,
	last_name       VARCHAR(32)      NOT NULL,
	birth_date      DATE             NOT NULL,
	height_cm       TINYINT UNSIGNED NOT NULL,
	gender          ENUM('m','f')    NOT NULL,
	last_pos_x      FLOAT            NULL,
	last_pos_y      FLOAT            NULL,
	last_pos_z      FLOAT            NULL,
	last_yaw        FLOAT            NULL,
	created_at      DATETIME         NOT NULL DEFAULT CURRENT_TIMESTAMP,
	updated_at      DATETIME         NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY (id),
	UNIQUE KEY uniq_characters_player_slot (steam_id, slot),
	CONSTRAINT fk_characters_player
		FOREIGN KEY (steam_id) REFERENCES players (steam_id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT chk_characters_height_cm CHECK (height_cm BETWEEN 50 AND 272)
) ENGINE = InnoDB
  DEFAULT CHARSET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS accounts (
	character_id    BIGINT UNSIGNED NOT NULL,
	account_id      VARCHAR(64)     NOT NULL,
	amount          INT             NOT NULL DEFAULT 0,
	updated_at      DATETIME        NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY (character_id, account_id),
	CONSTRAINT fk_accounts_character
		FOREIGN KEY (character_id) REFERENCES characters (id)
		ON DELETE CASCADE
		ON UPDATE CASCADE
) ENGINE = InnoDB
  DEFAULT CHARSET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS character_inventory (
	character_id    BIGINT UNSIGNED NOT NULL,
	slot            INT UNSIGNED    NOT NULL,
	item_id         VARCHAR(64)     NOT NULL,
	quantity        INT             NOT NULL,
	metadata        JSON            NULL,
	updated_at      DATETIME        NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY (character_id, slot),
	CONSTRAINT fk_inventory_character
		FOREIGN KEY (character_id) REFERENCES characters (id)
		ON DELETE CASCADE
		ON UPDATE CASCADE,
	CONSTRAINT chk_inventory_qty CHECK (quantity >= 0)
) ENGINE = InnoDB
  DEFAULT CHARSET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS permissions_groups (
	id              VARCHAR(32)  NOT NULL,
	display_name    VARCHAR(64)  NOT NULL,
	priority        INT          NOT NULL DEFAULT 0,
	created_at      DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP,
	updated_at      DATETIME     NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY (id),
	KEY idx_permissions_groups_priority (priority DESC),
	CONSTRAINT chk_permissions_groups_id CHECK (id REGEXP '^[a-z0-9_]+$')
) ENGINE = InnoDB
  DEFAULT CHARSET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS permissions_group_permissions (
	group_id    VARCHAR(32)  NOT NULL,
	permission  VARCHAR(128) NOT NULL,
	PRIMARY KEY (group_id, permission),
	CONSTRAINT fk_permissions_group_permissions_group
		FOREIGN KEY (group_id) REFERENCES permissions_groups (id)
		ON DELETE CASCADE
		ON UPDATE CASCADE
) ENGINE = InnoDB
  DEFAULT CHARSET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;

CREATE TABLE IF NOT EXISTS permissions_player_permissions (
	steam_id    BIGINT UNSIGNED NOT NULL,
	permission  VARCHAR(128)    NOT NULL,
	PRIMARY KEY (steam_id, permission),
	KEY idx_permissions_player_permissions_steam_id (steam_id)
) ENGINE = InnoDB
  DEFAULT CHARSET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;

INSERT IGNORE INTO permissions_groups (id, display_name, priority) VALUES
	('owner',   'Owner',   999),
	('default', 'Default', 0);

INSERT IGNORE INTO permissions_group_permissions (group_id, permission) VALUES
	('owner', '*');
