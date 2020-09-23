using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EgyptianKings : INation
    {
        Color bkgColor = Color.LightYellow;
        string nation = "Egyptian Kings";
        public Color DrawTerrain()
        {
            return bkgColor;
        }

        public void DrawHouse(Graphics g, Point p)
        {
            Pen pen = new Pen(Color.Black);


            Point t1 = new Point(p.X + 10, p.Y + 1);
            Point t2 = new Point(p.X + 8, p.Y - 15);
            Point t3 = new Point(p.X + 15, p.Y - 5);
            Triangle triangle1 = new Triangle(g, pen, p, t1, t2);
            triangle1.Draw();
            Triangle triangle2 = new Triangle(g, pen, t1, t2, t3);
            triangle2.Draw(); ;
        }

        public void DrawTree(Graphics g, Point p)
        {
            Pen pen = new Pen(Color.Black);

            Point p1 = new Point(p.X + 5, p.Y - 10);
            Point p2 = new Point(p.X - 5, p.Y - 10);
            Point p3 = new Point(p1.X + 5, p1.Y - 20);
            Point p4 = new Point(p1.X + 5, p1.Y - 20);
            Point p5 = new Point(p1.X, p.Y - 15);
            Point p6 = new Point(p2.X + 5, p2.Y - 20);
            Point p7 = new Point(p2.X - 5, p2.Y - 20);
            Point p8 = new Point(p2.X - 10, p2.Y - 20);

            g.DrawLine(pen, p, p1);
            g.DrawLine(pen, p, p2);
            g.DrawLine(pen, p1, p3);
            g.DrawLine(pen, p1, p4);
            g.DrawLine(pen, p1, p5);
            g.DrawLine(pen, p2, p6);
            g.DrawLine(pen, p2, p7);
            g.DrawLine(pen, p2, p8); ;
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }
        public String getName()
        {
            return nation;
        }
    }
}
