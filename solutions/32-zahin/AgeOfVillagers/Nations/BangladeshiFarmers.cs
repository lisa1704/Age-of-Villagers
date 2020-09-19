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
    class BangladeshiFarmers : INation
    {
        private string item;

        public BangladeshiFarmers()
        {
        }

        public void DrawHouse(Graphics g, Point point)
        {
            Point trianglePoint1 = new Point(point.X + 25, point.Y - 25);
            Point trianglePoint2 = new Point(point.X + 50, point.Y);
            Point rectanglePoint1 = new Point(point.X, point.Y + 25);
            Point rectanglePoint2 = new Point(trianglePoint2.X, trianglePoint2.Y + 25);
            Pen pen = new Pen(Color.Red);
            Triangle triangle = new Triangle(g, pen, point, trianglePoint1, trianglePoint2);
            triangle.DrawShape();
            Rectangles rectangle = new Rectangles(g, pen, point, trianglePoint2, rectanglePoint1, rectanglePoint2);
            rectangle.DrawShape();
        }

        public void DrawTree(Graphics g, Point point)
        {
            MessageBox.Show("Drawing Tree for Bangladeshi Farmers");
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            var message = new StringBuilder();
            MessageBox.Show("Drawing Water for Bangladeshi Farmers");
        }
    }
}
