using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class BDfarmer_House : CompositeShaping
    {
        public BDfarmer_House(Point top, Point baseTopLeft, Point baseBottomRight)
        {
            AddComponent(new MyTriangle(top, baseTopLeft, new Point(baseBottomRight.X, baseTopLeft.Y)));
            AddComponent(new MyRectangle(baseTopLeft, baseBottomRight));
        }
    }
}
