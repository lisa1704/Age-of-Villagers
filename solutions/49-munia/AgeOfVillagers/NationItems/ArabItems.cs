using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeOfVillagers.Shapes;
using Rectangle = AgeOfVillagers.Shapes.Rectangle;

namespace AgeOfVillagers.NationItems
{
    class ArabItems : INationItems
    {
        Point p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11;
        Pen pen = new Pen(Color.Black);
        public void House(Graphics g, Point p)
        {
            // draw tent  
            p1 = p;

            p2.X = p.X - 10;
            p2.Y = p.Y;

            p3.X = p.X - 16;
            p3.Y = p.Y - 6;

            p4.X = p.X - 13;
            p4.Y = p.Y - 16;

            p5.X = p.X - 5;
            p5.Y = p.Y - 12;

            Triangle t = new Triangle(g, p1, p2, p5);
            t.Draw();
            Rectangle r = new Rectangle(g, p2, p3, p5, p4);
            r.Draw();
        }

        public void Tree(Graphics g, Point p)
        {
            // draw tree
            p1.X = p.X - 16;
            p1.Y = p.Y - 24;

            p2.X = p.X - 7;
            p2.Y = p.Y;

            p3.X = p.X - 9;
            p3.Y = p.Y;

            p4.X = p.X - 7;
            p4.Y = p.Y - 16;

            p5.X = p.X - 9;
            p5.Y = p.Y - 16;

            p6.X = p.X - 8;
            p6.Y = p.Y - 16;

            p7.X = p.X ;
            p7.Y = p.Y - 24;

            p8.X = p.X - 5;
            p8.Y = p.Y - 24;

            p9.X = p.X - 8;
            p9.Y = p.Y - 24;

            p10.X = p.X - 12;
            p10.Y = p.Y - 24;

            p11.X = p.X - 16;
            p11.Y = p.Y - 24;

            Rectangle r = new Rectangle(g, p2, p3, p4, p5);
            r.Draw();
            g.DrawLine(pen, p6, p7);
            g.DrawLine(pen, p6, p8);
            g.DrawLine(pen, p6, p9);
            g.DrawLine(pen, p6, p10);
            g.DrawLine(pen, p6, p11);
        }

        public void Water(Graphics g, Point p)
        {
           
        }
    }
}
