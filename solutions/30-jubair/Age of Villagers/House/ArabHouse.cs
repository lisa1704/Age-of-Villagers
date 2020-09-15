using Age_of_Villagers.Shape;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Age_of_Villagers.House
{
    class ArabHouse : CompositeShape
    {
        public ArabHouse( Point baseLeft , Point baseMedium , Point topOne, Point baseRight , Point topTwo)
        {
            //Triangle
            //AddComponent(new Line(baseLeft, baseMedium)); ////////
            AddComponent(new Line(baseMedium, topOne));
            AddComponent(new Line(topOne, baseLeft));
            AddComponent(new Line(baseRight, baseLeft)); ////*****
            //Rectangle
           AddComponent(new Line(baseMedium,baseRight));
           AddComponent(new Line(topOne, topTwo));
           AddComponent(new Line(topTwo, baseRight));



        }
    }
}
