using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.NationItems
{
    class EgyptianItems : INationItems
    {
        Point p1, p2, p3, p4, p5, p6, p7, p8, p9;
        Pen pen = new Pen(Color.Black);
        public void House(Graphics g, Point p)
        {
           // draw pyramid           
        }

        public void Tree(Graphics g, Point p)
        {
            p1 = p;
            p2.X = p.X + 8;
            p2.Y = p.Y - 16;
            p3.X = p.X + 16;
            p3.Y = p.Y - 8;
            p4.X = p.X + 4;
            p4.Y = p.Y - 4;
            p5.X = p.X + 12;
            p5.Y = p.Y - 4;
            p6.X = p.X;
            p6.Y = p.Y - 2;
            p7.X = p.X + 16;
            p7.Y = p.Y - 2;
            p8.X = p.X + 6;
            p8.Y = p.Y;
            p9.X = p.X + 10;
            p9.Y = p.Y;

            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p2, p3);
            g.DrawLine(pen, p4, p6);
            g.DrawLine(pen, p4, p8);
            g.DrawLine(pen, p5, p9);
            g.DrawLine(pen, p5, p9);
        }

        public void Water(Graphics g, Point p)
        {
            // draw circle of radius 6px
        }
    }
}
