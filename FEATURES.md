# Features

Brief inventory of what currently ships in the gamemode (inherited from the Sandbox base, will evolve as Mirage RP systems are built on top).

## Player

- Spawn and respawn at `SpawnPoint` components
- Health and armor with regeneration hooks
- Damage system with headshot multiplier, damage tags, and pre-damage cancel events
- Fall damage based on landing velocity
- Death with ragdoll creation, force impulse, and clothing copy
- Gibbing on heavy damage
- Observer / spectator camera after death
- Flashlight toggle
- Voice chat with on-screen speaker indicator
- Noclip move mode (double-jump to toggle)
- Free camera mode with overlay UI
- Dresser for clothing layers and bone scaling
- Face poser with morph target editor and presets
- Per-player undo stack (128 steps, persists across deaths)
- Loadout save and restore
- Player stats tracking (kills, deaths, NPC kills, etc.)
- `die` and `kill` console commands for self-kill
- God mode flag on `PlayerData`

## Inventory and weapons

- Slot-based inventory with auto best-weapon selection
- Separate view model and world model per weapon
- Iron sights mode
- Reloading with per-weapon timing
- Ammo types: 9mm, rifle, rocket, shotgun, sniper
- Pistol: Colt 1911
- Pistol: Glock
- Assault rifle: M4A1
- SMG: MP5
- Shotgun
- Sniper rifle
- Crowbar (melee)
- Hand grenade (throwable)
- RPG with projectile entity
- Camera (photo tool)
- Physgun (physics manipulator)
- Toolgun (construction tool)
- Dropped weapon entities pickable from the ground

## Toolgun modes

- Weld, ball socket, slider, elastic, rope constraints
- Hydraulic constraint
- Hoverball
- Keep-upright joint
- No-collide
- Unbreakable
- Remover
- Resizer
- Stacker
- Mass editor
- Thruster spawner
- Balloon spawner
- Wheel spawner
- Emitter spawner
- Decal placer
- Trail attacher
- Linker (between objects)
- Cookies (sticker placement)
- Snap grid for precise placement

## Game systems

- Multiplayer host-authoritative lobby (32 max, 50 tick)
- RPC attributes (`Rpc.Host`, `Rpc.Owner`, `Rpc.Broadcast`) and `Sync` replicated fields
- Ban system with persistence
- Kick system
- Per-player limits: props, explosives, balloons, constraints, emitters, thrusters (configurable via convars)
- Achievements (e.g. friends online, connection)
- Game preferences and server settings panels
- Full scene save and load (diff against baseline)
- Cleanup system to reset map to baseline state
- Demo recording

## Spawning

- Prop spawner with workshop integration and sort modes
- Scripted entity spawner (`.sent` resources)
- Mount spawner (other game mounts)
- Duplicator (save and load contraptions as JSON)
- Spawnlists with favorites and workshop sharing

## Map elements

- Doors
- Buttons and toggles
- Trigger push
- Trigger teleport
- Func mover (animated brush volumes)
- Map player spawn points

## Items and pickups

- Health pickup
- Ammo pickups: 9mm, rifle, rocket, shotgun
- Inventory pickup (gives a stored loadout)
- Dropped weapon pickup

## Entities

- Dynamite (player-placed explosive)
- Emitter (particle / sound source)
- Scripted emitter (custom emitter resource)
- Point light entity
- Spotlight entity
- TV entity (in-world video screen)
- Sittable seats (chairs, toilet, ladder, car-seat, kickstool, trolley, etc.)
- Balloons, thrusters, hydraulics, wheels (toolgun-placed)

## NPCs

- NPC base component with NavMesh agent integration
- Combat layers and schedule system
- Behavior tasks: move-to, look-at, fire weapon, pick-up prop, drop prop, say, wait
- Speech / dialog system
- Scientist NPC
- Rollermine NPC

## UI and HUD

- Chat with system messages and emojis
- Kill feed with weapon icons
- Scoreboard with rows per player
- Nameplates above players
- Vitals HUD (health and armor bars)
- Voice chat speaker list
- Inventory hotbar with preset slots
- Spawn menu: props, entities, mounts, dupes, spawnlists, save menu, users, weapon settings, AI settings, cleanup, utilities
- Tool info panel
- Toast notifications
- Owner labels above spawned objects
- Drag and drop UI components
- Context menus
- Dresser editor UI
- Face poser editor UI

## Effects and feel

- Camera noise (handheld feel)
- Environment shake on explosions
- Bullet tracer effects
- Self-collision sounds
- Post-processing pipeline with `PostProcessResource`
- Ambient cookies (light cookies / textures)

## Localization

- Localization folder ready for translation strings

## Roleplay (planned)

Nothing RP-specific yet. The vision is documented in [README.md](README.md): identity, economy, jobs, vehicles, properties, RP inventory, phone, IC/OOC chat, admin tools.
