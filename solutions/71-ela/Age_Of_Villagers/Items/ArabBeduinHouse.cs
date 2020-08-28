using System.Drawing;

namespace Age_Of_Villagers
{
    public class ArabBeduinHouse : CompositeShape
    {

        
        public ArabBeduinHouse(Point location, ItemSize houseSize)
        {
            var topLeft = location;
            
            var bottomLeft= new Point(location.X - houseSize.width *5/16, location.Y+houseSize.height * 5 / 8);
            var bottomMid = new Point(location.X + houseSize.width *5/ 16 , location.Y + houseSize.height * 5 / 8);
            var bottomRight = new Point(bottomMid.X+ houseSize.width*6/16 , bottomMid.Y-houseSize.height*6/16);
            var topRight = new Point(location.X + houseSize.width *6/ 16,location.Y-houseSize.height*6/16);



            AddComponent(new Triangle(topLeft, bottomLeft, bottomMid));
            AddComponent(new Rectangle(topLeft,topRight,bottomMid, bottomRight));

              
        }

    }



}
