using System.Drawing;

namespace AgeOfVillagers
{
    internal class InuitHunterHouse : IVillageItem
    {
        public void Draw(Point e, Graphics g, Pen p)
        {
            int x = e.X;
            int y = e.Y;


            g.DrawLine(p, x, y, x + 20, y);
            g.DrawArc(p, x, y - 15, 20, 30, 180, 180);
            g.DrawArc(p, x + 6, y - 6, 8, 15, 180, 180);
        }
    }
}