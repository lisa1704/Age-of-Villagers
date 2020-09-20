using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BangladeshiWaterSource : IVillageItem
    {
        public void Draw(Point e, Graphics g, Pen p)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(p, x, y, x + 16, y + 12);
            g.DrawLine(p, x + 16, y + 12, x + 24, y);
            g.DrawLine(p, x + 24, y, x + 40, y + 10);
            g.DrawLine(p, x + 40, y + 10, x + 48, y);
            g.DrawLine(p, x + 48, y, x + 40, y - 10);
            g.DrawLine(p, x + 40, y - 10, x + 20, y - 6);
            g.DrawLine(p, x + 20, y - 6, x + 22, y - 10);
            g.DrawLine(p, x + 22, y - 10, x + 16, y - 8);
            g.DrawLine(p, x + 16, y - 8, x, y);
        }
    }
}
