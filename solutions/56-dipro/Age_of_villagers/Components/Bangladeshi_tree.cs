using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Age_of_villagers.Shape;
namespace Age_of_villagers.Components
{
    class Bangladeshi_tree : VillageComponent
    {
        private readonly Point top_Left,bottom_Right,center;
 


        public Bangladeshi_tree(Point point)
        {
            center = point;
            top_Left.X = point.X - 20;
            top_Left.Y = point.Y - 20;
            bottom_Right.X = point.X + 20;
            bottom_Right.Y = point.Y + 20;
            AddComp(new Arc(top_Left, bottom_Right));
            AddComp(new Shape.Rectangle(new Point(center.X - 2, center.Y), new Point(center.X + 2, center.Y + 40)));
        }
    }
}
