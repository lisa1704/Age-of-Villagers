using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    interface IComplexShape
    {
        void drawComponent(Graphics g, Point p);
    }

    class BDhouse : IComplexShape
    {
        Pen pen = new Pen(Color.Red);
        public void drawComponent(Graphics g, Point p)
        {
            Point trianglePoint1 = new Point(p.X + 16, p.Y - 16);
            Point trianglePoint2 = new Point(p.X + 24, p.Y);
            
            Point rectanglePoint1 = new Point(trianglePoint2.X, trianglePoint2.Y + 16);
            Point rectanglePoint2 = new Point(p.X, p.Y + 16);

            Triangle triangle = new Triangle(p, trianglePoint1, trianglePoint2);
            triangle.draw(g,pen);
            Rectangle rectangle = new Rectangle(p, trianglePoint2,rectanglePoint1,rectanglePoint2);
            rectangle.draw(g, pen);
        }
    }

    class BDtree : IComplexShape
    {
        Pen pen = new Pen(Color.Red);
        public void drawComponent(Graphics g, Point p)
        {
            g.DrawArc(pen, p.X, p.Y, 16, 16, 0, 360);
            Point pcenter = new Point(p.X + 8, p.Y + 8);
            Point p1 = new Point(pcenter.X - 2, pcenter.Y);
            Point p2 = new Point(pcenter.X + 2, pcenter.Y);
            Point p3 = new Point(p1.X, p1.Y + 16);
            Point p4 = new Point(p2.X, p3.Y);
            Rectangle rectangle = new Rectangle(p1, p2, p4, p3);
            rectangle.draw(g,pen);
            
        }
    }

    class Arabhouse : IComplexShape
    {
        Pen pen = new Pen(Color.Blue);
        public void drawComponent(Graphics g, Point p)
        {
            Point trianglePoint1 = new Point(p.X + 16, p.Y + 20);
            Point trianglePoint2 = new Point(p.X - 16, p.Y + 20);
            
            Triangle triangle = new Triangle(trianglePoint2, trianglePoint1,p);
            triangle.draw(g,pen);

            Point rectanglePoint1 = new Point(p.X + 13, p.Y - 10);
            Point rectanglePoint2 = new Point(p.X + 28, p.Y + 10);

            Rectangle rectangle = new Rectangle(p,rectanglePoint1,rectanglePoint2, trianglePoint1);
            rectangle.draw(g, pen);


        }
    }

    class Egypthouse : IComplexShape
    {
        Pen pen = new Pen(Color.Brown);
        public void drawComponent(Graphics g, Point p)
        {
            Point p1 = new Point(p.X + 8, p.Y + 32);
            Point p2 = new Point(p.X - 16, p.Y + 26);
            Point p3 = new Point(p.X + 18, p.Y + 18);

            Triangle triangle = new Triangle(p, p1, p2);
            triangle.draw(g, pen);
            g.DrawLine(pen, p, p3);
            g.DrawLine(pen, p3, p1);

        }
    }

    class Arabtree : IComplexShape
    {
        Pen pen = new Pen(Color.Red);
        public void drawComponent(Graphics g, Point p)
        {
            Point rectanglp1 = new Point(p.X - 2, p.Y);
            Point rectanglep2 = new Point(p.X + 2, p.Y);
            Point rectanglep3 = new Point(p.X + 2, p.Y + 18);
            Point rectanglep4 = new Point(p.X - 2, p.Y + 18);

            Rectangle rectangle = new Rectangle(rectanglp1, rectanglep2, rectanglep3, rectanglep4);
            rectangle.draw(g, pen);

            Point p1 = new Point(p.X, p.Y - 30);
            Point p2 = new Point(p.X + 8, p.Y - 25);
            Point p3 = new Point(p.X - 8, p.Y - 25);
            Point p4 = new Point(p.X + 16, p.Y - 20);
            Point p5 = new Point(p.X - 16, p.Y - 20);
            g.DrawLine(pen, p, p1);
            g.DrawLine(pen, p, p2);
            g.DrawLine(pen, p, p3);
            g.DrawLine(pen, p, p4);
            g.DrawLine(pen, p, p5);


        }
    }

    class Egypttree : IComplexShape
    {
        Pen pen = new Pen(Color.Brown);
        public void drawComponent(Graphics g, Point p)
        {
            Point p1 = new Point(p.X, p.Y + 24);
            Point p2 = new Point(p.X - 6, p.Y);
            Point p3 = new Point(p.X + 6, p.Y);
            Point p4 = new Point(p2.X - 9, p.Y + 5);
            Point p5 = new Point(p3.X + 9, p.Y + 5);
            Point p6 = new Point(p5.X + 9, p.Y + 10);
            Point p7 = new Point(p4.X - 9, p.Y + 10);
            Point p8 = new Point(p1.X - 15, p1.Y - 30);
            Point p9 = new Point(p1.X + 15, p1.Y - 30);
            g.DrawLine(pen, p8, p1);
            g.DrawLine(pen, p9, p1);
            g.DrawLine(pen, p8, p7);
            g.DrawLine(pen, p8, p4);
            g.DrawLine(pen, p8, p2);
            g.DrawLine(pen, p5, p9);
            g.DrawLine(pen, p3, p9);
            g.DrawLine(pen, p6, p9);
        }
    }


}
