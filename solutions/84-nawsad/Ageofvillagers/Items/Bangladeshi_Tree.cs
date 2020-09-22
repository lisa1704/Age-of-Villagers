using Ageofvillagers.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers
{
    class Bangladeshi_Tree : IItems
    {
        public void Draw(Graphics g, Pen p,int x,int y)
        {
            Circle C = new Circle(g, p, x, y);
            C.drawshape();
            Rectangle rec = new Rectangle(g, p, x + 48, y + 30, 5, 100);
            rec.drawshape();
        }
    }
}
