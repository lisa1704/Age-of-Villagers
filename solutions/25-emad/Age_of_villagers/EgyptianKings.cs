using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_villagers
{
    class EgyptianKings : INations
    {

        Color bg_color = Color.Yellow;



        public void DrawHouse(Graphics graphics, Point point)
        {
            Pen pen = new Pen(Color.Black);
           
            
                Point trianglepoint1 = new Point(point.X + 10, point.Y + 1);
                Point trianglepoint2 = new Point(point.X + 8, point.Y - 15);
                Point trianglepoint3 = new Point(point.X + 15, point.Y - 5);
                Triangle triangle1 = new Triangle(graphics, pen, point, trianglepoint1, trianglepoint2);
                triangle1.Draw();
                Triangle triangle2 = new Triangle(graphics, pen, trianglepoint1, trianglepoint2, trianglepoint3);
                triangle2.Draw();
            
        }

        public Color DrawBackground()
        {
            return bg_color;
        }

        
        public void DrawTree(Graphics graphics, Point point)
        {
            Pen pen = new Pen(Color.Black);
            
                Point p1 = new Point(point.X + 5, point.Y - 10);
                Point p2 = new Point(point.X - 5, point.Y - 10);
                Point p3 = new Point(p1.X + 5, p1.Y - 20);
                Point p4 = new Point(p1.X + 5, p1.Y - 20);
                Point p5 = new Point(p1.X, point.Y - 15);
                Point p6 = new Point(p2.X + 5, p2.Y - 20);
                Point p7 = new Point(p2.X - 5, p2.Y - 20);
                Point p8 = new Point(p2.X - 10, p2.Y - 20);

                graphics.DrawLine(pen, point, p1);
                graphics.DrawLine(pen, point, p2);
                graphics.DrawLine(pen, p1, p3);
                graphics.DrawLine(pen, p1, p4);
                graphics.DrawLine(pen, p1, p5);
                graphics.DrawLine(pen, p2, p6);
                graphics.DrawLine(pen, p2, p7);
                graphics.DrawLine(pen, p2, p8);
            
        }

        
        public void DrawWaterSource(Graphics graphics, Point point)
        {
            Pen pen = new Pen(Color.Black);

            Circle circle = new Circle(graphics, pen, point, 30, 30, 0, 360);
            circle.Draw();

        }

        public void getName()
        {
            throw new NotImplementedException();
        }
    }
}
