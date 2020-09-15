using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    class InuitHunters : INation
    {
        Pen p = new Pen(Color.Yellow);
        public void DrawHouse(Graphics g, Point pt)
        {
            InuitHouse inhouse = new InuitHouse(pt);
            inhouse.Draw(g);
        }

        public void DrawTree(Graphics g, Point pt)
        {
            g.DrawLine(p, pt.X, pt.Y, 100, 100);
        }

        public void DrawWaterSource(Graphics g, Point pt)
        {
            throw new NotImplementedException();
        }
    }
}
