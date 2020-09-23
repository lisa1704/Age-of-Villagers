using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class BDfarmer_House : CompositeShaping
    {
        public BDfarmer_House(Point point)
        {
            Point Top = new Point(point.X, point.Y);
            Point TopLeft = new Point(point.X - 25, point.Y + 15);
            Point BottomRight = new Point(point.X + 25, point.Y + 40);
            Point TopRight = new Point(BottomRight.X, TopLeft.Y);

            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new Triangle(Top, TopLeft, TopRight));

        }
    }
}
