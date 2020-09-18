using System.Drawing;

namespace Age_Of_Villagers
{
    internal class ArabBedouinHouse : IVillageItem
    {
        public void Draw(Point e, Graphics g, Pen p)
        {
            int x = e.X;
            int y = e.Y;

            g.DrawLine(p, x - 10, y, x + 10, y);
            g.DrawLine(p, x, y - 10, x - 10, y);
            g.DrawLine(p, x, y - 10, x + 10, y);

            g.DrawLine(p, x, y - 10, x + 10, y - 15);
            g.DrawLine(p, x + 10, y, x + 20, y - 5);
            g.DrawLine(p, x + 10, y - 15, x + 20, y - 5);


        }
    }
}