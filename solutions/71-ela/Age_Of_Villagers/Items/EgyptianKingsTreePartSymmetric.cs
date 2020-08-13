using System.Drawing;

namespace Age_Of_Villagers
{
    public class EgyptianKingsTreePartSymmetric : CompositeShape
    {



        public EgyptianKingsTreePartSymmetric(Point bottom, Point mid, int leafHeight, int leafWidth)
        {

            var firstLeaf = new Point(mid.X - leafWidth, mid.Y - leafHeight);
            var midLeaf = new Point(mid.X, mid.Y - leafHeight);
            var lastLeaf = new Point(mid.X + leafWidth, mid.Y - leafHeight);



            AddComponent(new Line(bottom, mid));
            AddComponent(new Line(mid, firstLeaf));
            AddComponent(new Line(mid, midLeaf));
            AddComponent(new Line(mid, lastLeaf));




        }

    }



}
