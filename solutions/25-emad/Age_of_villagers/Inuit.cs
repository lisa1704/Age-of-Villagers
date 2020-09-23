using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_villagers
{
    public class Inuit : INations
    {
        Color bg_color = Color.White;


        string nationName = "Inuit Hunters";
        public void DrawHouse(Graphics graphics, Point point)
        {
            Pen pen = new Pen(Color.Black);
            
                Point p1 = new Point(point.X - 16, point.Y);
                Point p2 = new Point(point.X + 16, point.Y);
                Point p3 = new Point(point.X - 8, point.Y - 16);
                Point center = new Point(point.X - 8, point.Y - 8);

                Circle innerCircle = new Circle(graphics, pen, center, 8, 8, 180, 180);
                innerCircle.Draw();
                Circle outerCircle = new Circle(graphics, pen, p3, 16, 16, 180, 180);
                outerCircle.Draw();

                graphics.DrawLine(pen, p1, p2);
            
        }

        public Color DrawBackground()
        {
            return bg_color;
        }




        NullValuesHandler nullwater = new NullValuesHandler();

        public void DrawWaterSource(Graphics graphics, Point point)
        {

            nullwater.DrawWaterSource(graphics, point);

        }


        NullValuesHandler nulltree = new NullValuesHandler();

        public void DrawTree(Graphics graphics, Point point)
        {
            nulltree.DrawTree(graphics,point);
        }


        public String getName()
        {
            return nationName;
        }
    }
}
