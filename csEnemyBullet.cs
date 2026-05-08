using System.Drawing;

namespace Astroidinator_SDE2025_Jkra
{
    internal class csEnemyBullet
    {
        public int X;
        public int Y;
        public int Speed = 8;
        public int Width = 16;
        public int Height = 4;
        public int Damage;
        public bool Active = true;

        public csEnemyBullet(int startX, int startY, int dmg)
        {
            X = startX;
            Y = startY;
            Damage = dmg;
        }

        // ✅ ENEMY SHOOTS LEFT → RIGHT
        public void Move()
        {
            X += Speed;
            if (X > 2000)
                Active = false;
        }

        public Rectangle Bounds()
        {
            return new Rectangle(X, Y, Width, Height);
        }
    }
}