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
    class ArabBedouin : INation
    {
        Pen pen = new Pen(Color.Red);
         public ArabBedouin()
        {

        }

        public void DrawHouse(Graphics g, Point point)
        {
            Point trianglePoint1 = new Point(point.X + 25, point.Y + 50);
            Point trianglePoint2 = new Point(point.X - 25, point.Y + 50);
            Point rectanglePoint1 = new Point(point.X + 50, point.Y - 25);
            Point rectanglePoint2 = new Point(point.X + 50, point.Y + 25);
            Triangle triangle = new Triangle(g, pen, trianglePoint2, trianglePoint1, point);
            triangle.DrawShape();
            Rectangles rectangle = new Rectangles(g, pen, point, rectanglePoint1, trianglePoint1, rectanglePoint2);
            rectangle.DrawShape();
        }

        public void DrawTree(Graphics g, Point point)
        {
            MessageBox.Show("Drawing Tree for Arab Bedouin");
        }
        public void DrawWaterSource(Graphics g, Point point)
        {
            MessageBox.Show("Bedouin villages do not build their own water source");
        }
    }
}
