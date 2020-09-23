using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
   public class Egyptian_House : CompositeShaping
    {
        public Egyptian_House(Point point)
        {
            Point top = new Point(point.X, point.Y);
            Point mediumLeft = new Point(point.X - 16, point.Y + 24);
            Point bottom = new Point(point.X + 3, point.Y + 30);
            Point mediumRight = new Point(point.X + 16, point.Y + 16);

            AddComponent(new Line(top, mediumLeft));
            AddComponent(new Line(mediumLeft, bottom));
            AddComponent(new Line(bottom, mediumRight));
            AddComponent(new Line(mediumRight, top));
            AddComponent(new Line(top, bottom));


        } 
    }
}
