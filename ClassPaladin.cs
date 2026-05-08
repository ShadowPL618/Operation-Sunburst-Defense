using System.Drawing;

namespace Astroidinator_SDE2025_Jkra
{
    internal class csPaladin
    {
        public int X;
        public int Y;

        public int Health;
        public int MaxHealth;
        public int Speed;
        public int FireRate;
        public int Damage;

        private int fireTimer = 0;

        public bool Round2 { get; private set; } = false;

        public Image Img;
        public int Width = 80;
        public int Height = 100;

        public csPaladin(int startX, int startY)
        {
            X = startX;
            Y = startY;

            MaxHealth = 200;
            Health = 200;
            Speed = 5;
            FireRate = 5;
            Damage = 25;

            try { Img = Image.FromFile("images/paladin.png"); }
            catch { Img = null; }
        }

        // ✅ Fire rate ALWAYS increases per tick
        public void Tick()
        {
            fireTimer++;
        }

        // ✅ Fire only when timer passes FireRate
        public bool CanFire()
        {
            if (fireTimer >= FireRate)
            {
                fireTimer = 0;
                return true;
            }
            return false;
        }

        public void EnterRound2()
        {
            if (Round2) return;

            Round2 = true;
            MaxHealth /= 2;
            Health = MaxHealth;
            Speed = (int)(Speed * 0.6f);
            FireRate = (int)(FireRate * 1.25f);
        }

        public Rectangle Bounds()
        {
            return new Rectangle(X, Y, Width, Height);
        }
    }
}