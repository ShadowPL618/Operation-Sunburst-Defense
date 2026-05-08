using System;
using System.Drawing;

namespace Astroidinator_SDE2025_Jkra
{
    // ── BASE ENEMY CLASS ───────────────────────────────────────────
    internal class csEnemy
    {
        // Position
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        // Stats
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Speed { get; set; }
        public int Damage { get; set; }
        public int FireRate { get; set; }       // ms between shots
        public int HitChance { get; set; }      // 0-100, lower = harder to hit
        public int SpawnProbability { get; set; }// 0-100, weight for random spawn

        // State
        public bool IsAlive { get; set; }
        public Image EnemyImage { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        protected Random rand = new Random();
        private int fireTimer = 0;

        public csEnemy() { IsAlive = true; }

        // Move left to right across screen
        public virtual void Move()
        {
            PositionX += Speed;
        }

        // Returns true when this enemy should fire
        public bool ShouldFire()
        {
            fireTimer++;
            if (fireTimer >= FireRate)
            {
                fireTimer = 0;
                return true;
            }
            return false;
        }

        // Take damage, returns true if killed
        public bool TakeDamage(int dmg)
        {
            Health -= dmg;
            if (Health <= 0)
            {
                Health = 0;
                IsAlive = false;
                return true;
            }
            return false;
        }

        // Bounding box for collision detection
        public System.Drawing.Rectangle GetBounds()
        {
            return new System.Drawing.Rectangle(PositionX, PositionY, Width, Height);
        }
    }

    // ── NCR TROOPER ────────────────────────────────────────────────
    internal class csNCRTrooper : csEnemy
    {
        public csNCRTrooper(int startY)
        {
            Health = 15;
            MaxHealth = 15;
            Speed = 2;
            Damage = 1;
            FireRate = 30;   // fires often
            HitChance = 70;   // easy to hit, big profile
            SpawnProbability = 50;   // most common
            Width = 50;
            Height = 80;
            PositionX = -Width;
            PositionY = startY;

            try { EnemyImage = Image.FromFile("images/NCRtrooper.png"); }
            catch { EnemyImage = null; }
        }
    }

    // ── NCR MARKSMAN ───────────────────────────────────────────────
    internal class csNCRMarksman : csEnemy
    {
        public csNCRMarksman(int startY)
        {
            Health = 25;
            MaxHealth = 25;
            Speed = 1;
            Damage = 10;   // rifle hits hard
            FireRate = 60;  // slower fire rate
            HitChance = 45;   // crouching, smaller profile
            SpawnProbability = 25;
            Width = 45;
            Height = 70;
            PositionX = -Width;
            PositionY = startY;

            try { EnemyImage = Image.FromFile("images/NCRmarksman.png"); }
            catch { EnemyImage = null; }
        }
    }

    // ── NCR MISSILE TROOPER ────────────────────────────────────────
    internal class csNCRMissileTrooper : csEnemy
    {
        public csNCRMissileTrooper(int startY)
        {
            Health = 40;
            MaxHealth = 40;
            Speed = 1;
            Damage = 60;   // missile does massive damage
            FireRate = 120;  // very slow fire rate
            HitChance = 75;   // large target
            SpawnProbability = 10;
            Width = 70;
            Height = 85;
            PositionX = -Width;
            PositionY = startY;

            try { EnemyImage = Image.FromFile("images/NCRmissiletrooper.png"); }
            catch { EnemyImage = null; }
        }
    }

    // ── BERSERK TROOPER ────────────────────────────────────────────
    internal class csBerserkTrooper : csEnemy
    {
        public csBerserkTrooper(int startY)
        {
            Health = 50;
            MaxHealth = 50;
            Speed = 5;    // very fast
            Damage = 15;
            FireRate = 30;
            HitChance = 55;   // fast moving, harder to hit
            SpawnProbability = 15;
            Width = 48;
            Height = 75;
            PositionX = -Width;
            PositionY = startY;

            try { EnemyImage = Image.FromFile("images/BerserkTrooper.png"); }
            catch { EnemyImage = null; }
        }
    }

    // ── NCR VETERAN RANGER ─────────────────────────────────────────
    internal class csNCRVeteranRanger : csEnemy
    {
        public csNCRVeteranRanger(int startY)
        {
            Health = 60;
            MaxHealth = 60;
            Speed = 2;
            Damage = 100;   // anti-materiel rifle
            FireRate = 80;
            HitChance = 30;   // duster coat, evasive, very hard to hit
            SpawnProbability = 5;    // rarest enemy
            Width = 55;
            Height = 90;
            PositionX = -Width;
            PositionY = startY;

            try { EnemyImage = Image.FromFile("images/NCRVeteranRanger.jpg"); }
            catch { EnemyImage = null; }
        }
    }
}