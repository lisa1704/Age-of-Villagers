using System.Drawing;

namespace Age_Of_Villagers
{
    public class BangladeshiFarmersHouse : CompositeShape
    {

       



        public BangladeshiFarmersHouse(Point Location, ItemSize houseSize)
        {
            var top = Location;
            var roofBaseRight = new Point(Location.X-houseSize.height / 2, Location.Y+houseSize.width / 2);
            var roofBaseLeft = new Point(Location.X + houseSize.height / 2, Location.Y + houseSize.width / 2);
            var groundLeft = new Point(roofBaseLeft.X,roofBaseLeft.Y+houseSize.height/2);
            var groundRight = new Point(roofBaseRight.X, groundLeft.Y);



            AddComponent(new Triangle(top, roofBaseRight, roofBaseLeft));
            AddComponent(new Rectangle(roofBaseLeft,roofBaseRight,groundLeft,groundRight));
       

        }

    }



}
