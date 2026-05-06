<p align='center'><img src='#' alt='Mirage' /></p>

<h1 align='center'>Mirage</h1>
<p align='center'><a href='#'>Discord</a> - <a href='#'>Site officiel</a></p>

<p align='center'><b>Gamemode roleplay développé sur-mesure pour le serveur <a href='#'>Mirage</a> sur s&box. Inspiré des serveurs RP FiveM, le projet construit toute la logique RP, l'interface custom et les systèmes propres au serveur par-dessus le jeu <a href='https://github.com/Facepunch/sandbox'>Sandbox</a> officiel de Facepunch.</b></p>

## ✨ Vision du gamemode

Le projet est en début de développement. L'objectif à terme :

- **Identité RP** : nom, prénom, métier, papiers d'identité, fiche de personnage persistante
- **Économie** : argent en banque/liquide, virements, jobs, commerces joueurs
- **Métiers et factions** : police, médecin, mécano, gangs, whitelist
- **Véhicules** : achat, garages, plaques d'immatriculation, état mécanique
- **Propriétés** : achat/location de logements, coffres, accès partagés
- **Inventaire RP** : items roleplay (clés, téléphone, papiers, drogues...) au-delà des armes du sandbox
- **Téléphone** : SMS, appels, annonces, applications custom
- **Chat RP** : OOC/IC, propagation par distance, radios
- **Administration** : outils staff, logs, sanctions, tickets

Tout n'arrivera pas tout de suite — on construit brique par brique.

## 🏗️ Base technique

Le projet repose sur le code source du jeu **Sandbox** officiel de Facepunch ([Facepunch/sandbox](https://github.com/Facepunch/sandbox)), publié sous licence MIT. On garde la base utile (joueurs, armes, physique, spawn menu, undo, save system, NPCs...) et on construit la logique RP par-dessus.

L'architecture du code est documentée dans [CLAUDE.md](CLAUDE.md) : Components/Scene s&box, host-authoritative, événements `Local.IPlayerEvents` / `Global.IPlayerEvents`, systèmes singletons `GameObjectSystem<T>`, etc.

## 🔧 Build

Pas de build CLI : s&box compile depuis l'éditeur.

1. Ouvrir l'éditeur **s&box**
2. Ajouter ce dossier comme projet (`mirage.sbproj`)
3. Lancer la scène `scenes/sandbox.scene`

Les fichiers `*.csproj`, `*.sln`, `obj/`, `bin/`, `.sbox/` sont générés par l'éditeur et sont ignorés par git — ne pas les commiter.

## 🙏 Crédits

- **[Facepunch](https://facepunch.com/)** — pour le jeu Sandbox dont ce projet est dérivé, et pour s&box.
- **lets-pop** — auteur du gamemode Mirage.
