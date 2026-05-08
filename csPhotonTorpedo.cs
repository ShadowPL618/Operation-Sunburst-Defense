using System.Drawing;

namespace Astroidinator_SDE2025_Jkra
{
    internal class csPhotonTorpedo
    {
        public int X;
        public int Y;
        public int Speed = 12;
        public int Width = 22;
        public int Height = 6;
        public bool Active = true;
        public int Damage = 20;

        public csPhotonTorpedo(int startX, int startY)
        {
            X = startX;
            Y = startY;
        }

        // ✅ PLAYER SHOOTS RIGHT → LEFT
        public void Move()
        {
            X -= Speed;
            if (X < -50)
                Active = false;
        }

        public Rectangle Bounds()
        {
            return new Rectangle(X, Y, Width, Height);
        }
    }
}