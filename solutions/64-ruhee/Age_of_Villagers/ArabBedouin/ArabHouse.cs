using Microsoft.CodeAnalysis.Editing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers.Age_of_Villagers;

namespace Age_of_Villagers.ArabBedouin
{
    public class ArabHouse : CShape
    {
        public ArabHouse(Point pt)
        {
            Point pt1 = new Point(pt.X - 30, pt.Y + 50);
            Point pt2 = new Point(pt.X + 30, pt.Y + 50);
            Point pt3 = new Point(pt.X + 38, pt.Y - 18);
            Point pt4 = new Point(pt2.X + 35, pt2.Y - 20);


            AddComponent(new Triangle(pt, pt1, pt2));
            AddComponent(new Line(pt, pt3));
            AddComponent(new Line(pt2, pt4));
            AddComponent(new Line(pt3, pt4));

        }
    }
}
