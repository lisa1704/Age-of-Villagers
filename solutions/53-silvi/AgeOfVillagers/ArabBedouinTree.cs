using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class ArabBedouinTree : IVillageItem
    {
        public void Draw(Point e, Graphics g, Pen p)
        {
            int x = e.X;
            int y = e.Y;

            g.DrawLine(p, x - 2, y, x + 2, y);
            g.DrawLine(p, x + 2, y, x + 2, y + 20);
            g.DrawLine(p, x - 2, y, x - 2, y + 20);
            g.DrawLine(p, x - 2, y + 20, x + 2, y + 20);

            g.DrawLine(p, x, y - 15, x, y);
            g.DrawLine(p, x + 15, y - 10, x, y);
            g.DrawLine(p, x - 15, y - 10, x, y);
            g.DrawLine(p, x + 17, y - 3, x, y);
            g.DrawLine(p, x - 17, y - 3, x, y);
        }
    }
}
