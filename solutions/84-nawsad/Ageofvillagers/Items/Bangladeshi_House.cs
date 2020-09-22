using Ageofvillagers.Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers
{
    class Bangladeshi_House : IItems
    {
        public void Draw(Graphics g, Pen p,int x,int y)
        {
            Rectangle rec = new Rectangle(g, p, x, y);
            rec.drawshape();
            Triangle T = new Triangle(g, p, x, y);
            T.drawshape();
        }
    }
}
