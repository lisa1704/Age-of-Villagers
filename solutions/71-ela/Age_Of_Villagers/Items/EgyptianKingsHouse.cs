using System.Drawing;

namespace Age_Of_Villagers
{
    public class EgyptianKingsHouse: CompositeShape
    {



        public EgyptianKingsHouse(Point location, ItemSize houseSize)
        {
            var top = location;
       
            var bottomleft = new Point(location.X-houseSize.width/2,location.Y+(houseSize.height*3)/4);
            var bottomMid = new Point(location.X,location.Y+houseSize.height);
            var bottomRight = new Point(location.X+ (houseSize.height * 5) / houseSize.width, location.Y + (houseSize.height * 3) / 5 );
          


            AddComponent(new Triangle(top,bottomleft,bottomMid ));
            AddComponent(new Triangle(top, bottomRight, bottomMid));


        }

    }



}
