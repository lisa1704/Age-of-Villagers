using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_villagers
{
   public class ArabBedouin : INations
    {

        Color bg_color = Color.LightYellow;

        string nationName = "Arab Bedouin";
        public void DrawHouse(Graphics graphics, Point point)
        {
            Pen pen = new Pen(Color.Black);
            
                Point trianglePoint1 = new Point(point.X + 16, point.Y + 20);
                Point trianglePoint2 = new Point(point.X - 16, point.Y + 20);
                Point rectanglePoint1 = new Point(point.X + 13, point.Y - 10);
                Point rectanglePoint2 = new Point(point.X + 24, point.Y + 10);
                Triangle triangle = new Triangle(graphics, pen, trianglePoint2, trianglePoint1, point);
                triangle.Draw();

                Rectangle rectangle = new Rectangle(graphics, pen, point, rectanglePoint1, trianglePoint1, rectanglePoint2);
                rectangle.Draw();
            
        }

        public Color DrawBackground()
        {
            return bg_color;
        }

        public void DrawTree(Graphics graphics, Point point)
        {
            Pen pen = new Pen(Color.Black);
           
                Point rectanglpoint1 = new Point(point.X - 1, point.Y);
                Point rectanglepoint2 = new Point(point.X + 1, point.Y);
                Point rectanglepoint3 = new Point(point.X - 1, point.Y + 15);
                Point rectanglepoint4 = new Point(point.X + 1, point.Y + 15);
                Point p1 = new Point(point.X, point.Y - 10);
                Point p2 = new Point(point.X - 5, point.Y - 8);
                Point p3 = new Point(point.X + 5, point.Y - 8);
                Point p4 = new Point(point.X - 12, point.Y - 3);
                Point p5 = new Point(point.X + 12, point.Y - 3);


                Rectangle rectangle = new Rectangle(graphics, pen, rectanglpoint1, rectanglepoint2, rectanglepoint3, rectanglepoint4);
                rectangle.Draw();


                graphics.DrawLine(pen, point, p1);
                graphics.DrawLine(pen, point, p2);
                graphics.DrawLine(pen, point, p3);
                graphics.DrawLine(pen, point, p4);
                graphics.DrawLine(pen, point, p5);
            
        }



        NullValuesHandler nullwater = new NullValuesHandler();



        public void DrawWaterSource(Graphics graphics, Point point)
        {

            nullwater.DrawWaterSource(graphics,point);

        }

        /*public void getName()
        {
            throw new NotImplementedException();
        }*/


        public string getName()
        {
            return nationName;
        }
    }
}
