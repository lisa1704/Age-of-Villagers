using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class ArabBedouins : INation
    {
        Color bkgColor = Color.Gold;
        string nation = "Arab Bedouin";
        public Color DrawTerrain()
        {
            return bkgColor;
        }
        public void DrawHouse(Graphics g, Point pt)
        {
            Pen pen = new Pen(Color.Black);

            Point t1 = new Point(pt.X + 16, pt.Y + 20);
            Point t2 = new Point(pt.X - 16, pt.Y + 20);
            Point r1 = new Point(pt.X + 13, pt.Y - 10);
            Point r2 = new Point(pt.X + 24, pt.Y + 10);
            Triangle triangle = new Triangle(g, pen, t2, t1, pt);
            triangle.Draw();

            Rectangle rectangle = new Rectangle(g, pen, pt, r1, t1, r2);
            rectangle.Draw();
        }

        public void DrawTree(Graphics g, Point pt)
        {
            Pen pen = new Pen(Color.Black);

            Point r1 = new Point(pt.X - 1, pt.Y);
            Point r2 = new Point(pt.X + 1, pt.Y);
            Point r3 = new Point(pt.X - 1, pt.Y + 15);
            Point r4 = new Point(pt.X + 1, pt.Y + 15);
            Point p1 = new Point(pt.X, pt.Y - 10);
            Point p2 = new Point(pt.X - 5, pt.Y - 8);
            Point p3 = new Point(pt.X + 5, pt.Y - 8);
            Point p4 = new Point(pt.X - 12, pt.Y - 3);
            Point p5 = new Point(pt.X + 12, pt.Y - 3);


            Rectangle rectangle = new Rectangle(g, pen, r1, r2, r3, r4);
            rectangle.Draw();


            g.DrawLine(pen, pt, p1);
            g.DrawLine(pen, pt, p2);
            g.DrawLine(pen, pt, p3);
            g.DrawLine(pen, pt, p4);
            g.DrawLine(pen, pt, p5);

        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }
        public string getName()
        {
            return nation;
        }
    }
}
