using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers
{
    class EgyptianKing : INation
    {
        Pen pen = new Pen(Color.Black);
        public EgyptianKing()
        {

        }

        public void DrawHouse(Graphics g, Point point)
        {
            Point trianglepoint1 = new Point(point.X + 50, point.Y + 25);
            Point trianglepoint2 = new Point(point.X + 50, point.Y - 75);
            Point trianglepoint3 = new Point(point.X + 100, point.Y - 25);
            Triangle triangle1 = new Triangle(g, pen, point, trianglepoint1, trianglepoint2);
            triangle1.DrawShape();
            Triangle triangle2 = new Triangle(g, pen, trianglepoint1, trianglepoint2, trianglepoint3);
            triangle2.DrawShape();
        }

        public void DrawTree(Graphics g, Point point)
        {
            Point p1 = new Point(point.X + 25, point.Y - 25);
            Point p2 = new Point(point.X - 25, point.Y - 25);
            Point p3 = new Point(p1.X + 25, p1.Y - 25);
            Point p4 = new Point(p1.X, p1.Y - 25);
            Point p5 = new Point(p1.X + 25, point.Y - 25);
            Point p6 = new Point(p2.X + 25, p2.Y - 25);
            Point p7 = new Point(p2.X - 5, p2.Y - 25);
            Point p8 = new Point(p2.X -25, p2.Y - 25);
            g.DrawLine(pen, point, p1);
            g.DrawLine(pen, point, p2);
            g.DrawLine(pen, p1, p3);
            g.DrawLine(pen, p1, p4);
            g.DrawLine(pen, p1, p5);
            g.DrawLine(pen, p2, p6);
            g.DrawLine(pen, p2, p7);
            g.DrawLine(pen, p2, p8); ;
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            Circle circle = new Circle(g, pen, point, 50, 50, 0, 360);
            circle.DrawShape();
        }
        public Color DrawTerrain()
        {
            return Color.Gold;
        }
    }
}
