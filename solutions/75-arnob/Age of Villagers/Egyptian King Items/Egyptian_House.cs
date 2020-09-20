using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Egyptian_King
{
    class Egyptian_House : CompositeShaping
    {
        public Egyptian_House(Point top, Point mediumLeft, Point bottom, Point mediumRight)
        {

            AddComponent(new Line(top, mediumLeft));
            AddComponent(new Line(mediumLeft, bottom));
            AddComponent(new Line(bottom, mediumRight));
            AddComponent(new Line(mediumRight, top));
            AddComponent(new Line(top, bottom));


        }
    }
}
