using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    class EgyptianKings : INation
    {
        Pen p = new Pen(Color.Red);
        public void DrawHouse(Graphics g, Point pt)
        {
            g.DrawLine(p, pt.X, pt.Y, 100, 100);
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
