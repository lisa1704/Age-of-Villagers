using System.Drawing;

namespace Age_Of_Villagers
{
    public class InuitHuntersHouse : CompositeShape
    {



        public InuitHuntersHouse(Point location, ItemSize houseSize)
        {
            Point baseLeft, baseRight;
            baseLeft = new Point(location.X, location.Y + houseSize.width/ 2);
            baseRight = new Point(location.X + houseSize.width, location.Y + houseSize.width / 2);


            AddComponent(new Arc(location.X, location.Y, houseSize.width, houseSize.height, 0, -180));
            AddComponent(new Line(baseLeft, baseRight));
            AddComponent(new Arc(location.X + houseSize.height / 3, location.Y + houseSize.height / 2 - houseSize.height / 8, houseSize.height / 4, houseSize.height / 4, 0, -180));



        }

    }



}
