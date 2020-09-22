using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Inuit_House : CompositeShaping
    {
        public Inuit_House(Point point)
        {
            Point startPoint = new Point(point.X, point.Y);
            Point point1 = new Point(point.X + 16, point.Y);

            AddComponent(new Line(startPoint, point1));
            AddComponent(new ArcShape(startPoint.X, startPoint.Y - 16, 16, 32, 180, 180));
            AddComponent(new ArcShape(startPoint.X + 5, startPoint.Y - 6, 6, 12, 180, 180));

        }
    } 
}
