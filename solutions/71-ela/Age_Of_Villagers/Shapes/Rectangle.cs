using System.Drawing;

namespace Age_Of_Villagers
{
    public class Rectangle : CompositeShape
    {

        
      
                                                                 

        public Rectangle(Point topLeft,Point topRight, Point bottomLeft, Point bottomRight)
        {
           


          
            AddComponent(new Line(topLeft,topRight));
            AddComponent(new Line(topLeft,bottomLeft));
            AddComponent(new Line(bottomLeft,bottomRight));
            AddComponent(new Line(bottomRight,topRight));

        }

        
    }



}
