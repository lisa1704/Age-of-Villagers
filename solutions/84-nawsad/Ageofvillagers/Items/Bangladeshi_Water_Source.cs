using Ageofvillagers.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers
{
    class Bangladeshi_Water_Source : IItems
    {
        public void Draw(Graphics g, Pen p,int x,int y)
        {
            Line L1 = new Line(g, p, x, y, 50, -50);
            Line L2 = new Line(g, p, x, y, 50, 50);
            Line L3 = new Line(g, p, x + 50, y - 50, 30, -10);
            Line L4 = new Line(g, p, x + 50 + 30, y - 50 - 10, 30, 10);
            Line L5 = new Line(g, p, x + 50 + 30 + 30, y - 50 - 10 + 10, 30, -15);
            Line L6 = new Line(g, p, x + 50 + 30 + 30 + 30, y - 50 - 10 + 10 - 15, 30, 15);
            Line L7 = new Line(g, p, x + 140 + 30, y - 50, -10, 60);
            Line L8 = new Line(g, p, x + 170 - 10, y + 10, -60, -20);
            Line L9 = new Line(g, p, x + 100, y - 10, x + 50, y + 50);
            L1.drawshape();
            L2.drawshape();
            L3.drawshape();
            L4.drawshape();
            L5.drawshape();
            L6.drawshape();
            L7.drawshape();
            L8.drawshape();
            L9.drawshape("Coordinate");
        }
    }
}
