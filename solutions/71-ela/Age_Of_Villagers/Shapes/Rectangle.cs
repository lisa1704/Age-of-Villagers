using System;
using System.Drawing;

namespace Age_Of_Villagers
{
    public class Rectangle : CompositeShape
    {

        public Point topLeft, topRight, bottomLeft, bottomRight;

        
      
                                                                 

        public Rectangle(Point topLeft,Point topRight, Point bottomLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;
           


          
            AddComponent(new Line(topLeft,topRight));
            AddComponent(new Line(topLeft,bottomLeft));
            AddComponent(new Line(bottomLeft,bottomRight));
            AddComponent(new Line(bottomRight,topRight));

        }


        public double  GetHeight()
        {
            var height = Math.Sqrt(Math.Pow((topLeft.X - bottomLeft.X), 2) + Math.Pow((topLeft.Y - bottomLeft.Y), 2));
            return height;

        }

        public double GetWidth()
        {
            var width = Math.Sqrt(Math.Pow((topLeft.X - topRight.X), 2) + Math.Pow((topLeft.Y - topRight.Y), 2));
            return width;

        }



    }



}
