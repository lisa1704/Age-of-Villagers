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
    class BDItems : INationItems
    {
        Point p1, p2, p3, p4, p5,p6;
        Pen pen = new Pen(Color.Black);
        public void House(Graphics g, Point p)
        {
            p1 = p;

            p2.X =p.X;
            p2.Y = p.Y - 8;

            p3.X = p.X - 8;
            p3.Y = p.Y - 16;

            p4.X = p.X -16;
            p4.Y = p.Y - 8;

            p5.X = p.X -16 ;
            p5.Y = p.Y  ;

            /*  g.DrawLine(pen, p1, p2);
              g.DrawLine(pen, p2, p3);
              g.DrawLine(pen, p3, p4);
              g.DrawLine(pen, p2, p4);
              g.DrawLine(pen, p1, p5);
              g.DrawLine(pen, p4, p5);
            */
            Triangle t = new Triangle(g, p2, p3, p4);
            t.Draw();
            Rectangle r = new Rectangle(g, p2, p4, p1, p5);
            r.Draw();

        }
        public void Tree(Graphics g, Point p)
        {
            p1.X = p.X - 16;
            p1.Y = p.Y - 24;

            p2.X = p.X -7;
            p2.Y = p.Y ;

            p3.X = p.X - 9;
            p3.Y = p.Y ;

            p4.X = p.X - 7;
            p4.Y = p.Y - 16;

            p5.X = p.X - 9;
            p5.Y = p.Y -16;



            // draw circle or radius 8
            Circle c = new Circle(g, p1, 16);
            c.Draw();
            Rectangle r = new Rectangle(g, p2, p3, p4, p5);
            r.Draw();
        }

        public void Water(Graphics g, Point p)
        {
            p1.X = p.X ;
            p1.Y = p.Y ;

            p2.X = p.X - 20;
            p2.Y = p.Y - 16;

            p3.X = p.X - 24;
            p3.Y = p.Y -12;

            p4.X = p.X - 17;
            p4.Y = p.Y - 6;

            p5.X = p.X - 9;
            p5.Y = p.Y -2;
            p6.X = p.X - 4;
            p6.Y = p.Y - 17;

            g.DrawLine(pen,p1,p6);
            g.DrawLine(pen, p6, p2);
            g.DrawLine(pen,p2,p3);
            g.DrawLine(pen,p4,p3);
            g.DrawLine(pen,p5,p4);
            g.DrawLine(pen,p1,p5);

        }
    }
}
