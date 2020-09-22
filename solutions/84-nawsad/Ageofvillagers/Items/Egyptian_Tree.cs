using Ageofvillagers.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers
{
    class Egyptian_Tree : IItems
    {
        public void Draw(Graphics g, Pen p,int x,int y)
        {
            Line L = new Line(g, p, x, y, x + 50, y - 80);
            Line L1 = new Line(g, p, x, y, x - 50, y - 80);
            Line L2 = new Line(g, p, x - 30, y - 50, x - 30, y - 85);
            Line L3 = new Line(g, p, x - 30, y - 50, x - 60, y - 50);
            Line L4 = new Line(g, p, x + 30, y - 50, 30, 0);
            Line L5 = new Line(g, p, x + 30, y - 50, 0, -35);
            L.drawshape("Coordinate");
            L1.drawshape("Coordinate");
            L2.drawshape("Coordinate");
            L3.drawshape("Coordinate");
            L4.drawshape();
            L5.drawshape();
        }
    }
}
