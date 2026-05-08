# Operation Sunburst Defense

> *"The NCR thought Helios One was won. They were wrong."*

A C# Windows Forms side-scrolling shooter set in the brutal, sun-scorched world
of Fallout: New Vegas. You are a Brotherhood of Steel Paladin — power armored,
outgunned, and the last line of defense. Hold the line or die trying.

## The Story
The Battle of Helios One is over. The NCR claimed victory.
But the Brotherhood doesn't forget, and the Mojave doesn't forgive.
Waves of NCR soldiers are pushing through — Troopers, Marksmen, Missile
Troopers, and the most feared of all: the Veteran Rangers.
You have one Paladin. You have photon torpedoes. You have no retreat.

## What's In The Game

### Enemies — Five Threats, Zero Mercy
| Enemy | Health | Speed | Damage | Notes |
|---|---|---|---|---|
| NCR Trooper | 15 | Fast | 1 | Common, fires often |
| NCR Marksman | 25 | Slow | 10 | Crouching — hard to hit |
| Missile Trooper | 40 | Slow | 60 | Rare, absolutely devastating |
| Berserk Trooper | 50 | Very Fast | 15 | Charges hard |
| NCR Veteran Ranger | 60 | Medium | 100 | Rarest. Anti-materiel. You will feel it. |

### The Paladin
- 200 HP, fast firing, hits for 25 per torpedo
- **Round 2** kicks in mid-game: health halved, speed reduced, fire rate drops —
  because this is Fallout and nothing stays easy

### The Outro
Nine hand-captioned lore slides walk you through the fall of Helios One,
the rise of Caesar's Legion, and the march of the Malpais Legate toward Hoover Dam.
Because context matters. This isn't just a shooter — it has a soul.

### Arduino Controller Support *(work in progress)*
The game is built to be controlled by an Arduino UNO R4 WiFi joystick over serial.
The connection works. The commands stream. The game just isn't listening yet.
Controller support is actively being developed — when it lands, this will be
played the way it was meant to be played. The game is playable with WASD till then.

## Tech Stack
- C# — Windows Forms, GDI+ rendering
- Double-buffered GamePanel for smooth, tear-free gameplay
- Serial communication via `System.IO.Ports`
- Arduino UNO R4 WiFi (C++, I2C LCD, LED Matrix)

## Setup
1. Clone the repo and open in Visual Studio
2. Drop your assets into the `images/` folder:
   `paladin.png`, `NCRtrooper.png`, `NCRmarksman.png`,
   `NCRmissiletrooper.png`, `BerserkTrooper.png`, `NCRVeteranRanger.jpg`,
   `slide1.png` through `slide9.png`
3. Build and run — keyboard controls work out of the box
4. Optionally flash `controler.ino` to your Arduino and connect over serial
