using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Inuit_Hunter
{
    class Inuit_House : CompositeShaping
    {
        public Inuit_House(Point startPoint, Point pt1)
        {
            AddComponent(new Line(startPoint, pt1));
            AddComponent(new ArcShape(startPoint.X, startPoint.Y - 16, 16, 32, 180, 180));
            AddComponent(new ArcShape(startPoint.X + 5, startPoint.Y - 6, 6, 12, 180, 180));

        }
    }
}
