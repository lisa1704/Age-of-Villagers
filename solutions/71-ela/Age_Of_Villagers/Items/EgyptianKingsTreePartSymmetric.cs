using System.Drawing;

namespace Age_Of_Villagers
{
    public class EgyptianKingsTreePartSymmetric : CompositeShape
    {



        public EgyptianKingsTreePartSymmetric(Point bottom, Point mid, Point left, Point right, int leafHeight, int leafWidth)
        {



            var midPoint = new Point((bottom.X + mid.X) / 2, (bottom.Y + mid.Y) / 2);




            AddComponent(new Line(bottom, mid));
            AddComponent(new Line(midPoint, left));
            AddComponent(new Line(midPoint, right));
        




        }

    }



}
