using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
        Color bkgColor = Color.Green;
        Pen pn = new Pen(Color.Red);

        string nation = "Bangladeshi Farmers";
        public Color DrawTerrain()
        {
            return bkgColor;
        }
        public void DrawHouse(Graphics g, Point pt)
        {
            Point t1 = new Point(pt.X + 25, pt.Y - 25);
            Point t2 = new Point(pt.X + 50, pt.Y);
            Point r1 = new Point(pt.X, pt.Y + 25);
            Point r2 = new Point(t1.X, t2.Y + 25);

            Triangle t = new Triangle(g, pn, pt, t1, t2);

            t.DrawShape();

            Rectangle r = new Rectangle(g, pn, pt, t2, r1, r2);

            r.DrawShape(); ;
        }

        public void DrawTree(Graphics g, Point pt)
        {
            Point r1 = new Point(pt.X - 2, pt.Y);
            Point r2 = new Point(pt.X + 2, pt.Y);
            Point r3 = new Point(pt.X - 2, pt.Y + 24);
            Point r4 = new Point(pt.X + 2, pt.Y + 24);
            Point center = new Point(pt.X + 12, pt.Y + 12);
            Circle circle = new Circle(g, pn, center, 24, 24, 0, 360);
            circle.DrawShape();
            Rectangle rectangle = new Rectangle(g, pn, r1, r2, r3, r4);
            rectangle.DrawShape();
        }

        public void DrawWaterSource(Graphics g, Point pt)
        {
            Point p1 = new Point(pt.X - 5, pt.Y + 16);
            Point p2 = new Point(pt.X, pt.Y + 16);
            Point p3 = new Point(pt.X + 5, pt.Y + 16);
            Point p4 = new Point(pt.X + 5, pt.Y + 16);
            Point p5 = new Point(pt.X + 16, pt.Y + 5);
            Point p6 = new Point(pt.X + 16, pt.Y);
            Point p7 = new Point(pt.X + 5, pt.Y + 5);
            Point p8 = new Point(pt.X + 5, pt.Y);

            g.DrawLine(pn, pt, p1);
            g.DrawLine(pn, p1, p2);
            g.DrawLine(pn, p2, p3);
            g.DrawLine(pn, p3, p4);
            g.DrawLine(pn, p4, p5);
            g.DrawLine(pn, p5, p6);
            g.DrawLine(pn, p6, p7);
            g.DrawLine(pn, p7, p8);
            g.DrawLine(pn, p8, pt);
        }
        public string getName()
        {
            return nation;
        }
    }
}
