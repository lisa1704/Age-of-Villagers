using System.Drawing;

namespace Age_Of_Villagers
{
    public class EgyptianKingsHouse: CompositeShape
    {



        public EgyptianKingsHouse(Point location, ItemSize waterSourceSize)
        {
            var top = new Point();
            var bottomleft = new Point();
            var bottomMid = new Point();
            var bottomRight = new Point();



            AddComponent(new Triangle(top,bottomleft,bottomMid ));
            AddComponent(new Triangle(top, bottomRight, bottomMid));


        }

    }



}
