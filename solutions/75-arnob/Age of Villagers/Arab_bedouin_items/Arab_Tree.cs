using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Arab_bedouin
{
    public class Arab_Tree : CompositeShaping
    {
        
        
            public Arab_Tree(Point _point)
            {
            Point startPoint = new Point(_point.X, _point.Y);
            Point point1 = new Point(_point.X + 16, _point.Y - 8);
            Point point2 = new Point(_point.X - 16, _point.Y - 8);
            Point point3 = new Point(_point.X + 12, _point.Y - 20);
            Point point4 = new Point(_point.X - 12, _point.Y - 20);
            Point point5 = new Point(_point.X, _point.Y - 26);
            Point topLeftRectangle = new Point(_point.X - 2, _point.Y + 16);
            Point bottomRightRectangle = new Point(_point.X + 2, _point.Y);


                AddComponent(new Line(startPoint, point1));
                AddComponent(new Line(startPoint, point2));
                AddComponent(new Line(startPoint, point3));
                AddComponent(new Line(startPoint, point4));
                AddComponent(new Line(startPoint, point5));

                // Rectangle
                AddComponent(new Rectangle(topLeftRectangle, bottomRightRectangle));

        } 

    }
}
