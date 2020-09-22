using Ageofvillagers.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers
{
    class Arab_House : IItems
    {
        public void Draw(Graphics g, Pen p,int x,int y)
        {
            Triangle T = new Triangle(g, p, x, y);
            T.drawshape();
            Line L1 = new Line(g, p, x + 100, y, 100, -20);
            L1.drawshape();
            Line L2 = new Line(g, p, (x + x + 100) / 2, y - 87, 100, -20);
            L2.drawshape();
            Line L3 = new Line(g, p, x + 100 + 100, y - 20, ((x + x + 100) / 2) + 100, y - 87 - 20);
            L3.drawshape("Coordinate");
        }
    }
}
