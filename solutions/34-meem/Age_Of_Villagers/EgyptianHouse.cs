using System.Drawing;

namespace Age_Of_Villagers
{
    internal class EgyptianHouse : IVillageItem
    {
        public void Draw(Point e, Graphics g, Pen p)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(p, x, y, x + 30, y + 10);
            g.DrawLine(p, x + 30, y + 10, x + 50, y - 10);
            g.DrawLine(p, x + 20, y - 30, x, y);
            g.DrawLine(p, x + 20, y - 30, x + 30, y + 10);
            g.DrawLine(p, x + 20, y - 30, x + 50, y - 10);
        }
    }
}