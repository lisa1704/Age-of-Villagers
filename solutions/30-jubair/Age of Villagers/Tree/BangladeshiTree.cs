using Age_of_Villagers.Shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Tree
{
    public class BangladeshiTree : CompositeShape
    {
        public BangladeshiTree(Point mainPoint, Point bottomRight, Point topPoint, Point topLeft )
        {
            AddComponent(new MyRectangle(topLeft, bottomRight));
            AddComponent(new NewEllipse(mainPoint, topPoint));

            //AddComponent(new Line(topLeft, bottomRight));
            //AddComponent(new NewEllipse(mainPoint, bottomRight));
            //AddComponent(new Line(mainPoint, topLeft));
            //AddComponent(new Line(mainPoint, topRight));
            //AddComponent(new Line(mainPoint, bottomRight));
        }
    }
}
