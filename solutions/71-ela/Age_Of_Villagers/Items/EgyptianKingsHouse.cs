using System.Drawing;

namespace Age_Of_Villagers
{
    public class EgyptianKingsHouse : CompositeShape
    {


        public EgyptianKingsHouse(Point location, ItemSize houseSize)
        {
            var top = location;
            var bottomMid = new Point(location.X + houseSize.width / 4, location.Y + houseSize.height);


            var bottomleft = new Point(bottomMid.X - houseSize.width * 10 / 16, location.Y + houseSize.height - houseSize.height / 4);

            var bottomRight = new Point(bottomMid.X + houseSize.width * 6 / 16, location.Y + (houseSize.height / 2));



            AddComponent(new Triangle(top, bottomMid, bottomleft));
            AddComponent(new Triangle(top, bottomMid, bottomRight));



        }

    }



}
