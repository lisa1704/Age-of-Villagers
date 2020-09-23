using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
   public class BDfarmer_Tree : CompositeShaping
    {


        public BDfarmer_Tree(Point point)
       
        {
            Point mainPoint = new Point(point.X, point.Y);
            Point bottomRight = new Point(point.X + 18, point.Y + 40);
            Point topPoint = new Point(point.X + 30, point.Y + 24);
            Point topLeft = new Point(point.X + 14, point.Y + 16);



            AddComponent(new Rectangle(topLeft, bottomRight));
            AddComponent(new EllipseShape(mainPoint, topPoint));
        }

     
    
    }
}
    
