using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
  public class Egyptian_WaterSource : CompositeShaping
    {
        public Egyptian_WaterSource(Point point)
        {
            Point pt1 = new Point(point.X, point.Y);
            Point pt2 = new Point(point.X + 12, point.Y + 12) ;
            AddComponent(new EllipseShape(pt1, pt2));
        }
    }
} 
