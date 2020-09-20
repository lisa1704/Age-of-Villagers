using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Null_Item : CompositeShaping
    {
        Point point = new Point();

        public Null_Item(Point point)
        {
            this.point = point;
        }

        public Point DrawNothing()
        {
            return point;
        }
    }
}
