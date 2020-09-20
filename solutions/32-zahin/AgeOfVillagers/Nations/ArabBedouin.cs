using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgeOfVillagers.Shapes;

namespace AgeOfVillagers
{
    public class ArabBedouin : INation
    {
        Pen pen = new Pen(Color.Black);
         public ArabBedouin()
        {

        }

        public string DrawHouse(Graphics g, Point point)
        {
            Point trianglePoint1 = new Point(point.X + 25, point.Y + 50);
            Point trianglePoint2 = new Point(point.X - 25, point.Y + 50);
            Point rectanglePoint1 = new Point(point.X + 50, point.Y - 25);
            Point rectanglePoint2 = new Point(point.X + 50, point.Y + 25);
            Triangle triangle = new Triangle(g, pen, trianglePoint2, trianglePoint1, point);
            triangle.DrawShape();
            Rectangles rectangle = new Rectangles(g, pen, point, rectanglePoint1, trianglePoint1, rectanglePoint2);
            rectangle.DrawShape();

            return "Bedouin House";
        }

        public string DrawTree(Graphics g, Point point)
        {
            Point rectanglpoint1 = new Point(point.X - 2, point.Y);
            Point rectanglepoint2 = new Point(point.X + 2, point.Y);
            Point rectanglepoint3 = new Point(point.X - 2, point.Y + 50);
            Point rectanglepoint4 = new Point(point.X + 2, point.Y + 50);
            Point p1 = new Point(point.X, point.Y - 35);
            Point p2 = new Point(point.X - 25, point.Y - 25);
            Point p3 = new Point(point.X + 25, point.Y - 25);
            Point p4 = new Point(point.X - 35, point.Y - 10);
            Point p5 = new Point(point.X + 35, point.Y - 10);
            Rectangles rectangle = new Rectangles(g, pen, rectanglpoint1, rectanglepoint2, rectanglepoint3, rectanglepoint4);
            rectangle.DrawShape();
            g.DrawLine(pen, point, p1);
            g.DrawLine(pen, point, p2);
            g.DrawLine(pen, point, p3);
            g.DrawLine(pen, point, p4);
            g.DrawLine(pen, point, p5);

            return "Bedouin Tree";
        }
        public string DrawWaterSource(Graphics g, Point point)
        {
            MessageBox.Show("Bedouin villages do not build their own water source");
            return "Bedouin villages do not build their own water source";
        }
        public Color DrawTerrain()
        {
            return Color.LightGoldenrodYellow;
        }
    }
}
