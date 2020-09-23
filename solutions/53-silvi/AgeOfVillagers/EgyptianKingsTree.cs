using System.Drawing;

namespace AgeOfVillagers
{
    class EgyptianKingsTree : IVillageItem
    {
        public void Draw(Point e, Graphics g, Pen p)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(p, x, y, x + 10, y + 10);
            g.DrawLine(p, x + 10, y + 10, x + 20, y);
            g.DrawLine(p, x - 10, y - 5, x, y);
            g.DrawLine(p, x - 5, y - 10, x, y);
            g.DrawLine(p, x + 5, y - 10, x, y);

            g.DrawLine(p, x + 20, y - 10, x + 20, y);
            g.DrawLine(p, x + 25, y - 10, x + 20, y);
            g.DrawLine(p, x + 30, y - 5, x + 20, y);

        }
    }
}