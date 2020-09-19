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
        Pen pen = new Pen(Color.Red);
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
            MessageBox.Show("Drawing Tree for Egyptian Kings");
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            var message = new StringBuilder();
            MessageBox.Show("Drawing Water for Egyptian Kings");
        }
    }
}
