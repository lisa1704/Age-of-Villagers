using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    class ArabBedouin : INation
    {
        Pen p = new Pen(Color.Violet);
        public void DrawHouse(Graphics g, Point pt)
        {
            g.DrawLine(p, pt.X, pt.Y, 100, 100);
        }

        public void DrawTree()
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
