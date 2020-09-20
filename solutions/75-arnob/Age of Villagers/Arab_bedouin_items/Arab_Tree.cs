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
        
        
            public Arab_Tree(Point startPoint, Point point1, Point point2, Point point3, Point point4, Point point5, Point topLeftRectangle, Point bottomRightRectangle)
            {
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
