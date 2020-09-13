using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class InuitHunters : INations
    {
        Pen p = new Pen(Color.Gray);
        public string DrawHouse(Graphics g, Point pt)
        {
            ShapeRectangle r = new ShapeRectangle(new Point(pt.X, pt.Y), new Point(pt.X + 10, pt.Y + 20));
            r.Paint(g);
            //g.DrawLine(p, pt.X, pt.Y, pt.X + 16, pt.X + 16);
            return "Igloo";
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
