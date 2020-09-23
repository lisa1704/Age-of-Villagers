using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    public class BangladeshFarmer_Tree : CompositeShape
    {
        public BangladeshFarmer_Tree(Point MainPoint)
        {
            Point TopRight = new Point(MainPoint.X + 100, MainPoint.Y);
            Point BottomRight = new Point(MainPoint.X + 30, MainPoint.Y + 150);
            Point TopPoint = new Point(MainPoint.X + 100, MainPoint.Y + 90);
            Point TopLeft = new Point(MainPoint.X + 20, MainPoint.Y + 20);

            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new ElipseShape(MainPoint, TopPoint));
        }
    }
}
