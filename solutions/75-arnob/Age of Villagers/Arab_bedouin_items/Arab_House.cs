using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Arab_bedouin
{
   public class Arab_House : CompositeShaping
    {
        public Arab_House(Point _point)
        {
            Point baseLeft = new Point(_point.X, _point.Y);
            Point baseMedium = new Point(_point.X - 4, _point.Y + 13);
            Point topOne = new Point(_point.X + 4, _point.Y + 13);
            Point baseRight = new Point(_point.X + 8, _point.Y - 3);
            Point topTwo = new Point(_point.X + 12, _point.Y + 11);

            //Triangle
            AddComponent(new Line(baseLeft, baseMedium)); 
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
