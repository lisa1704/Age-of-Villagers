using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Of_Villagers
{
    class BangladeshiHouse : IVillageItem
    {
        

        public void Draw(Point e, Graphics g, Pen p)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawLine(p, x, y, x + 50, y);
            g.DrawLine(p, x + 50, y, x + 50, y + 25);
            g.DrawLine(p, x + 50, y + 25, x, y + 25);
            g.DrawLine(p, x, y + 25, x, y);
            g.DrawLine(p, x, y, x + 25, y - 25);
            g.DrawLine(p, x + 50, y, x + 25, y - 25);

        }
    }
}
