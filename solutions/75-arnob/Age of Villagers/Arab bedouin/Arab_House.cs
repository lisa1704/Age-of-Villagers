using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Arab_bedouin
{
    class Arab_House : CompositeShaping
    {
        public Arab_House(Point baseLeft, Point baseMedium, Point topOne, Point baseRight, Point topTwo)
        {
            //Triangle
            //AddComponent(new Line(baseLeft, baseMedium)); 
            AddComponent(new Line(baseMedium, topOne));
            AddComponent(new Line(topOne, baseLeft));
            AddComponent(new Line(baseRight, baseLeft)); 


            //Rectangle
            AddComponent(new Line(baseMedium, baseRight));
            AddComponent(new Line(topOne, topTwo));
            AddComponent(new Line(topTwo, baseRight));



        }
    }
}
