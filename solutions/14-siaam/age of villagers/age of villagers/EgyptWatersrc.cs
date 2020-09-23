using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    class EgyptWatersrc : IComplexShape
    {
        Pen pen = new Pen(Color.Blue);
        public void drawComponent(Graphics g, Point p)
        {
            g.DrawArc(pen, p.X, p.Y, 12, 12, 0, 360);
        }
    }
}
