using System.Drawing;

namespace Age_Of_Villagers
{
    public class ArabBeduinHouse : CompositeShape
    {



        public ArabBeduinHouse(Point location, ItemSize houseSize)
        {
            var topLeft = location;
            var topRight = new Point(); 
            var bottomLeft= new Point(location.X - houseSize.width / 3,houseSize.width/3);
            var bottomRight = new Point();
            var bottomMid = new Point();



            AddComponent(new Triangle(topLeft, bottomLeft, bottomMid));
            AddComponent(new Rectangle(topLeft,topRight,bottomMid, bottomRight));

              
        }

    }



}
