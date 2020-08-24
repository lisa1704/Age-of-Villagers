using System.Drawing;

namespace Age_Of_Villagers
{
    public class ArabBeduinHouse : CompositeShape
    {

        
        public ArabBeduinHouse(Point location, ItemSize houseSize)
        {
            var topLeft = location;
            
            var bottomLeft= new Point(location.X - houseSize.width /2- houseSize.width/6, location.Y+houseSize.height*2/3);
            var bottomMid = new Point(location.X + houseSize.width / 2 + houseSize.width / 6, location.Y + houseSize.height * 2 / 3);
            var bottomRight = new Point(location.X+ houseSize.width , bottomMid.Y-houseSize.width*3/8);
            var topRight = new Point(location.X + houseSize.width / 2,location.Y-houseSize.height/4);



            AddComponent(new Triangle(topLeft, bottomLeft, bottomMid));
            AddComponent(new Rectangle(topLeft,topRight,bottomMid, bottomRight));

              
        }

    }



}
