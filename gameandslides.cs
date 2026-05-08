using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Astroidinator_SDE2025_Jkra
{
    internal class gameandslides
    {
        // ── CORE REFERENCES ────────────────────────────────────────
        private GamePanel gamePanel;
        private Random rand = new Random();

        // ── GAME OBJECTS ───────────────────────────────────────────
        private csPaladin paladin;
        private List<csEnemy> enemies;
        private List<csPhotonTorpedo> playerBullets;
        private List<csEnemyBullet> enemyBullets;

        // ── GAME STATE ─────────────────────────────────────────────
        private bool gameRunning = false;
        private bool isRoundTwo = false;
        private bool round2Enabled = false;
        private int score = 0;
        private int spawnTimer = 0;
        private int spawnRate = 120; // ticks between spawns

        // ── DIFFICULTY SCALING ─────────────────────────────────────
        private float speedMultiplier = 1.0f;
        private float fireRateMultiplier = 1.0f;

        // ── BACKGROUNDS ────────────────────────────────────────────
        private Image backgroundRound1;
        private Image backgroundRound2;

        // ── INPUT FLAGS (set by Form1 keyboard / Arduino) ──────────
        public bool KeyUp { get; set; }
        public bool KeyDown { get; set; }
        public bool KeyLeft { get; set; }
        public bool KeyRight { get; set; }
        public bool KeyFire { get; set; }

        // ── EVENT: fires when the game ends ────────────────────────
        public event Action GameOver;

        // ── CONSTRUCTOR ────────────────────────────────────────────
        public gameandslides(GamePanel panel)
        {
            gamePanel = panel;
            gamePanel.Paint += OnPaint; // hook into panel's draw event

            enemies = new List<csEnemy>();
            playerBullets = new List<csPhotonTorpedo>();
            enemyBullets = new List<csEnemyBullet>();

            // Load backgrounds — fall back to black if missing
            try { backgroundRound1 = Image.FromFile("images/backgroundRound1.png"); }
            catch { backgroundRound1 = null; }

            try { backgroundRound2 = Image.FromFile("images/backgroundRound2.png"); }
            catch { backgroundRound2 = null; }
        }

        // ── START GAME ─────────────────────────────────────────────
        public void StartGame(int difficultyIndex, bool enableRound2)
        {
            round2Enabled = enableRound2;

            // Apply difficulty multipliers
            switch (difficultyIndex)
            {
                case 0: speedMultiplier = 1.0f; fireRateMultiplier = 1.0f; break; // Oliver - easy
                case 1: speedMultiplier = 1.3f; fireRateMultiplier = 0.85f; break; // Moore  - medium
                case 2: speedMultiplier = 1.6f; fireRateMultiplier = 0.70f; break; // Aurelius - hard
                case 3: speedMultiplier = 2.0f; fireRateMultiplier = 0.50f; break; // Malpais - legate
            }

            // Clear everything and spawn fresh paladin
            enemies.Clear();
            playerBullets.Clear();
            enemyBullets.Clear();

            paladin = new csPaladin(gamePanel.Width - 120, gamePanel.Height / 2);

            score = 0;
            spawnTimer = 0;
            spawnRate = 120;
            isRoundTwo = false;
            gameRunning = true;
        }

        // ── MAIN GAME TICK (called every 16ms by timer) ────────────
        public void Tick()
        {
            if (!gameRunning) return;

            paladin.Tick();        // advance paladin's fire cooldown
            MovePaladin();         // apply WASD / joystick input
            SpawnEnemy();          // spawn new enemies on a timer
            MoveEnemies();         // advance enemies left → right
            EnemyFire();           // let enemies shoot back
            MovePlayerBullets();   // move cyan torpedoes right → left
            MoveEnemyBullets();    // move orange bullets left → right
            CheckBulletHits();     // check all collisions
            CheckRoundTwo();       // check if player died / round 2 starts

            gamePanel.Invalidate(); // request a redraw
        }

        // ── PALADIN MOVEMENT ───────────────────────────────────────
        private void MovePaladin()
        {
            if (KeyUp) paladin.Y -= paladin.Speed;
            if (KeyDown) paladin.Y += paladin.Speed;
            if (KeyLeft) paladin.X -= paladin.Speed;
            if (KeyRight) paladin.X += paladin.Speed;

            // Clamp to panel bounds so paladin can't leave the screen
            paladin.X = Math.Max(0, Math.Min(gamePanel.Width - paladin.Width, paladin.X));
            paladin.Y = Math.Max(0, Math.Min(gamePanel.Height - paladin.Height, paladin.Y));

            // Fire if requested (KeyFire set by Enter key or right mouse)
            if (KeyFire)
            {
                FireTorpedo();
                KeyFire = false;
            }
        }

        // ── FIRE PLAYER BULLET ─────────────────────────────────────
        // Public so Form1 can call it from mouse click and Arduino FIRE
        public void FireTorpedo()
        {
            if (!gameRunning) return;
            if (!paladin.CanFire()) return;

            // Spawn bullet at the left edge of the paladin, vertically centered
            playerBullets.Add(new csPhotonTorpedo(
                paladin.X,
                paladin.Y + paladin.Height / 2));
        }

        // ── ENEMY FIRE ─────────────────────────────────────────────
        private void EnemyFire()
        {
            foreach (var enemy in enemies)
            {
                if (!enemy.ShouldFire()) continue;

                // Bullet spawns at right edge of enemy, shoots toward the paladin
                enemyBullets.Add(new csEnemyBullet(
                    enemy.PositionX + enemy.Width,
                    enemy.PositionY + enemy.Height / 2,
                    enemy.Damage));
            }
        }

        // ── SPAWN ENEMY ────────────────────────────────────────────
        private void SpawnEnemy()
        {
            spawnTimer++;
            if (spawnTimer < spawnRate) return;
            spawnTimer = 0;

            int y = rand.Next(0, gamePanel.Height - 90);
            csEnemy enemy = GetWeightedEnemy(y);

            // Scale speed and fire rate based on difficulty
            enemy.Speed = (int)(enemy.Speed * speedMultiplier);
            enemy.FireRate = (int)(enemy.FireRate * fireRateMultiplier);

            enemies.Add(enemy);
        }

        // ── WEIGHTED ENEMY SPAWN ───────────────────────────────────
        // Probabilities: Trooper 40%, Marksman 25%, Missile 15%,
        //                Berserk 15%, Veteran Ranger 5%
        private csEnemy GetWeightedEnemy(int y)
        {
            int roll = rand.Next(0, 100);
            if (roll < 40) return new csNCRTrooper(y);
            if (roll < 65) return new csNCRMarksman(y);
            if (roll < 80) return new csNCRMissileTrooper(y);
            if (roll < 95) return new csBerserkTrooper(y);
            return new csNCRVeteranRanger(y);
        }

        // ── MOVE ENEMIES ───────────────────────────────────────────
        private void MoveEnemies()
        {
            for (int i = enemies.Count - 1; i >= 0; i--)
            {
                enemies[i].Move();

                // If enemy reaches the right side, it hits the paladin directly
                if (enemies[i].PositionX > gamePanel.Width)
                {
                    paladin.Health -= enemies[i].Damage;
                    enemies.RemoveAt(i);
                }
            }
        }

        // ── MOVE PLAYER BULLETS ────────────────────────────────────
        private void MovePlayerBullets()
        {
            for (int i = playerBullets.Count - 1; i >= 0; i--)
            {
                playerBullets[i].Move();
                if (!playerBullets[i].Active)
                    playerBullets.RemoveAt(i);
            }
        }

        // ── MOVE ENEMY BULLETS ─────────────────────────────────────
        private void MoveEnemyBullets()
        {
            for (int i = enemyBullets.Count - 1; i >= 0; i--)
            {
                enemyBullets[i].Move();
                if (!enemyBullets[i].Active)
                    enemyBullets.RemoveAt(i);
            }
        }

        // ── COLLISION DETECTION ────────────────────────────────────
        private void CheckBulletHits()
        {
            // Player bullets vs enemies
            for (int i = playerBullets.Count - 1; i >= 0; i--)
            {
                var p = playerBullets[i];

                for (int e = enemies.Count - 1; e >= 0; e--)
                {
                    if (!p.Bounds().IntersectsWith(enemies[e].GetBounds())) continue;

                    // Hit! Apply damage
                    enemies[e].TakeDamage(p.Damage);
                    p.Active = false;

                    if (enemies[e].Health <= 0)
                    {
                        enemies.RemoveAt(e);
                        score += 10;
                    }
                    break; // one bullet hits one enemy
                }

                if (!p.Active) playerBullets.RemoveAt(i);
            }

            // Enemy bullets vs paladin
            for (int i = enemyBullets.Count - 1; i >= 0; i--)
            {
                var b = enemyBullets[i];
                if (!b.Bounds().IntersectsWith(paladin.Bounds())) continue;

                paladin.Health -= b.Damage;
                b.Active = false;
                enemyBullets.RemoveAt(i);
            }
        }

        // ── ROUND TWO / GAME OVER CHECK ────────────────────────────
        private void CheckRoundTwo()
        {
            if (!isRoundTwo && paladin.Health <= 0)
            {
                if (round2Enabled)
                {
                    // Wounded — retreat to Helios One with reduced stats
                    paladin.EnterRound2();
                    enemies.Clear();
                    enemyBullets.Clear();
                    isRoundTwo = true;
                    spawnRate = 90; // enemies spawn faster in round 2
                }
                else
                {
                    gameRunning = false;
                    GameOver?.Invoke();
                }
                return;
            }

            // Second death in round 2 → game over
            if (isRoundTwo && paladin.Health <= 0)
            {
                gameRunning = false;
                GameOver?.Invoke();
            }
        }

        // ── PAINT (called by GamePanel.Paint event) ────────────────
        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Draw background — black fallback if image missing
            Image bg = isRoundTwo ? backgroundRound2 : backgroundRound1;
            if (bg != null)
                g.DrawImage(bg, 0, 0, gamePanel.Width, gamePanel.Height);
            else
                g.Clear(Color.Black);

            if (!gameRunning) return;

            // Draw enemies (image if loaded, red rectangle as fallback)
            foreach (var enemy in enemies)
            {
                if (enemy.EnemyImage != null)
                    g.DrawImage(enemy.EnemyImage,
                        enemy.PositionX, enemy.PositionY,
                        enemy.Width, enemy.Height);
                else
                    g.FillRectangle(Brushes.Red,
                        enemy.PositionX, enemy.PositionY,
                        enemy.Width, enemy.Height);
            }

            // Draw player bullets (cyan)
            foreach (var p in playerBullets)
                g.FillRectangle(Brushes.Red, p.X, p.Y, p.Width, p.Height);

            // Draw enemy bullets (orange-red)
            foreach (var b in enemyBullets)
                g.FillRectangle(Brushes.Yellow, b.X, b.Y, b.Width, b.Height);

            // Draw paladin (image or gold fallback)
            if (paladin.Img != null)
                g.DrawImage(paladin.Img, paladin.X, paladin.Y,
                    paladin.Width, paladin.Height);
            else
                g.FillRectangle(Brushes.Gold,
                    paladin.X, paladin.Y, paladin.Width, paladin.Height);

            // Draw player health bar
            DrawPlayerHealthBar(g);

            // Draw score (top-left)
            g.DrawString($"Score: {score}",
                new Font("Arial", 12, FontStyle.Bold),
                Brushes.White, 10, 10);

            // Round 2 indicator
            if (isRoundTwo)
                g.DrawString("WOUNDED — HELIOS ONE",
                    new Font("Arial", 9, FontStyle.Bold),
                    Brushes.OrangeRed, 10, 35);
        }

        // ── PLAYER HEALTH BAR ──────────────────────────────────────
        private void DrawPlayerHealthBar(Graphics g)
        {
            int barW = 200, barH = 16;
            int barX = gamePanel.Width - barW - 10;
            int barY = 10;

            // Background (dark red = missing health)
            g.FillRectangle(Brushes.DarkRed, barX, barY, barW, barH);

            // Foreground color: green → orange → red as health drops
            float pct = (float)paladin.Health / paladin.MaxHealth;
            Color fill = pct > 0.5f ? Color.LawnGreen :
                         pct > 0.25f ? Color.Orange : Color.Red;

            g.FillRectangle(new SolidBrush(fill), barX, barY, (int)(barW * pct), barH);

            // HP text inside the bar
            g.DrawString($"HP: {paladin.Health}/{paladin.MaxHealth}",
                new Font("Arial", 8, FontStyle.Bold),
                Brushes.White, barX + 4, barY + 1);
        }

        // ── PUBLIC GETTERS ─────────────────────────────────────────
        public bool IsGameRunning() => gameRunning;
        public int GetScore() => score;
        public bool IsRoundTwoActive() => isRoundTwo;
    }
}