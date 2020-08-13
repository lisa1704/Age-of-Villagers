using System.Drawing;

namespace Age_Of_Villagers
{
    public class Triangle : CompositeShape
    {
 


        public Triangle(Point top, Point baseLeft,Point baseRight)
        {
           



            AddComponent(new Line(top, baseRight));
            AddComponent(new Line(top, baseLeft));
            AddComponent(new Line(baseRight, baseLeft));
        

        }


    }



}
