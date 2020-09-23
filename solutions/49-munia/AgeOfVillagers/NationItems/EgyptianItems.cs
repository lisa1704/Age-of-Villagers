using AgeOfVillagers.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = AgeOfVillagers.Shapes.Rectangle;

namespace AgeOfVillagers.NationItems
{
    class EgyptianItems : INationItems
    {
        Point p1, p2, p3, p4, p5, p6, p7, p8, p9 ;
        Pen pen = new Pen(Color.Black);
        public void House(Graphics g, Point p)
        {
            p1.X = p.X;
            p1.Y = p.Y - 8;
            p2.X = p.X - 10;
            p2.Y = p.Y;
            p3.X = p.X - 16;
            p3.Y = p.Y - 4;
            p4.X = p.X - 7;
            p4.Y = p.Y - 16;

            g.DrawLine(pen, p2, p4);
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p2, p3);
            g.DrawLine(pen, p1, p4);
            g.DrawLine(pen, p3, p4);
        }

        public void Tree(Graphics g, Point p)
        {
            p1.X = p.X;
            p1.Y = p.Y - 24;
            p2.X = p.X - 6;
            p2.Y = p.Y ;
            p3.X = p.X - 16;
            p3.Y = p.Y - 24;
            p4.X = p.X - 7;
            p4.Y = p.Y - 23;
            p5.X = p.X - 11;
            p5.Y = p.Y - 24;
            p6.X = p.X;
            p6.Y = p.Y - 6;
            p7.X = p.X - 16;
            p7.Y = p.Y - 13;
            p8.X = p.X - 6;
            p8.Y = p.Y - 10;
            p9.X = p.X - 17;
            p9.Y = p.Y  -11;

            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p2, p3);
            g.DrawLine(pen, p6, p8);
            g.DrawLine(pen, p9, p7);
            g.DrawLine(pen, p8, p4);
            g.DrawLine(pen, p9, p5);
        }

        public void Water(Graphics g, Point p)
        {
            Circle c = new Circle(g,p,12);
            c.Draw();
        }
    }
}
