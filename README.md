# ⚔️ The Curse of Damarel

**A text-based adventure game for the console, written in C#.** Pick a hero, roll for a weapon, choose your path, and fight your way to the final boss.

![C#](https://img.shields.io/badge/C%23-.NET-512bd4?style=flat-square&logo=dotnet&logoColor=white)
![Type](https://img.shields.io/badge/Type-Console%20RPG-informational?style=flat-square)
![License](https://img.shields.io/badge/License-MIT-green?style=flat-square)

## How a run works

1. **Create your hero.** Choose Male or Female (cosmetic only), then pick a class.
2. **Open the weapon box.** You get a random weapon of a random rarity.
3. **Choose your path.** Forest is the easier route and Planes is the harder one.
4. **Survive three fights.** After each win you get a random stat buff.
5. **Beat the final boss** of your path to reach the ending credits.

Lose any fight and the run ends.

## Classes

Swordsman · Archer · Berserker · Lumberjack · Spearman

Each class starts with its own stat spread, which is shown when you pick it.

## Weapons

Every run starts with a random weapon box. Rarity chances:

| Rarity | Chance |
|---|---|
| Common | 40% |
| Uncommon | 17% |
| Rare | 20% |
| Epic | 13% |
| Legendary | 10% |

## Paths and enemies

| Path | Difficulty | Enemies | Final boss |
|---|---|---|---|
| 🌲 Forest | Easy | Wolves, Bears, Gromp | **BAUBAU** |
| 🌾 Planes | Hard | Slime, Fungi, Earth Golem | **BLOBGLOB** |

You face three enemies on your path before the boss.

## Combat and buffs

Combat is turn-based. Attack speed decides who acts first, and damage is the attacker's damage minus the defender's defense.

After every fight you receive one random buff:

| Buff | Effect |
|---|---|
| ❤️ HP | Heal 215 (capped at your starting HP) |
| 🗡️ DMG | +10% damage |
| 🛡️ DEF | +25% defense |
| ⚡ ATSP | +33% attack speed |

There is also a **secret rare buff** that boosts all your stats at once and ignores your starting HP. If you receive an HP heal afterwards, your HP goes back to normal.

## Getting started

### Requirements
- [.NET SDK](https://dotnet.microsoft.com/download) (or Visual Studio with the .NET desktop workload)

### Run it

```bash
git clone https://github.com/KristiyanGorinov/TheCurseOfDamarel.git
cd TheCurseOfDamarel
dotnet run --project TheCurseOfDamarel
```

Or open `TheCurseOfDamarel.sln` in Visual Studio and press **F5**.

## Project structure

```
TheCurseOfDamarel/
├── TheCurseOfDamarel/        # Game source code
├── TheCurseOfDamarel.sln     # Visual Studio solution
├── LICENSE
└── README.md
```

## Roadmap

- [ ] Balance patches for classes, weapons and enemies
- [ ] Refactor the game logic into separate classes (heroes, enemies, weapons, fights)
- [ ] More paths, enemies and bosses
- [ ] Save system

## Author

**Kristiyan Gorinov** · [Portfolio](https://kgorinov.com) · [GitHub](https://github.com/KristiyanGorinov)

## License

Released under the [MIT License](LICENSE).
