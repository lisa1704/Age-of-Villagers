using System.Drawing;

namespace Age_Of_Villagers
{
    public class EgyptianKingsHouse: CompositeShape
    {



        public EgyptianKingsHouse(Point location, ItemSize houseSize)
        {
            var top = location;
            var bottomMid = new Point(location.X + houseSize.width / 4, location.Y + houseSize.height);


            var bottomleft = new Point(location.X-houseSize.width*3/4,bottomMid.Y-houseSize.height/4);
            
            var bottomRight = new Point(location.X+houseSize.width/2, location.Y + (houseSize.height/2));
          


            AddComponent(new Triangle(top,bottomleft,bottomMid ));
            AddComponent(new Triangle(top, bottomMid, bottomRight));



        }

    }



}
