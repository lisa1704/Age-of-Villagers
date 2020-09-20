using Age_of_Villagers.Shape;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Age_of_Villagers.House
{
    public class ArabHouse : CompositeShape
    {
        public ArabHouse(Point topOne, Point baseLeft , Point baseMedium, Point topTwo, Point baseRight)
           
        {
            //Triangle
            //AddComponent(new Line(baseLeft, baseMedium)); ////////
            AddComponent(new Line(baseMedium, topOne));
            AddComponent(new Line(topOne, baseLeft));
            AddComponent(new Line(baseMedium, baseLeft)); ////*****
            //Rectangle
           AddComponent(new Line(baseMedium,baseRight));
           AddComponent(new Line(topOne, topTwo));
           AddComponent(new Line(topTwo, baseRight));



        }
    }
}
