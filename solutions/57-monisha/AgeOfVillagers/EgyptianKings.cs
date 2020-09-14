using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EgyptianKings : INations
    {
        Pen p = new Pen(Color.SkyBlue);
        public string DrawHouse(Graphics g, Point pt)
        {
            g.DrawLine(p, pt.X, pt.Y, pt.X + 16, pt.X + 16);
            return "Piramid";
        }

        public void DrawTree(Graphics g, Point pt)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
