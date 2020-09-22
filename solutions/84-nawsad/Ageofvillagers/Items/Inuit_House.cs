using Ageofvillagers.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers
{
    class Inuit_House : IItems
    {
        public void Draw(Graphics g, Pen p,int x,int y)
        {
            Circle C = new Circle(g, p, x, y, 50, 50, -180);
            Circle C1 = new Circle(g, p, x - 25, y - 25, 100, 100, -180);
            Line L = new Line(g, p, x + 25, y + 25, 50, 0);
            Line L1 = new Line(g, p, x + 25, y + 25, -50, 0);
            C.drawshape();
            C1.drawshape();
            L.drawshape();
            L1.drawshape();
        }
    }
}
