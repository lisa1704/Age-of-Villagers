using Ageofvillagers.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers
{
    class Arab_Tree :IItems
    { 
        public void Draw(Graphics g, Pen p,int x,int y)
        {
            Rectangle D = new Rectangle(g, p, x, y, 5, 50);
            D.drawshape();
            Line L1 = new Line(g, p, (x + x + 5) / 2, (y + y + 5) / 2, 0, -50);
            Line L2 = new Line(g, p, (x + x + 5) / 2, (y + y + 5) / 2, 50, -40);
            Line L3 = new Line(g, p, (x + x + 5) / 2, (y + y + 5) / 2, 100, -30);
            Line L4 = new Line(g, p, (x + x + 5) / 2, (y + y + 5) / 2, -50, -40);
            Line L5 = new Line(g, p, (x + x + 5) / 2, (y + y + 5) / 2, -100, -30);
            L1.drawshape();
            L2.drawshape();
            L3.drawshape();
            L4.drawshape();
            L5.drawshape();
        }
    }
}
