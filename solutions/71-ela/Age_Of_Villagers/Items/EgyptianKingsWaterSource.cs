using System.Drawing;

namespace Age_Of_Villagers
{
    public class EgyptianKingsWaterSource : CompositeShape
    {



        public EgyptianKingsWaterSource(Point location, ItemSize waterSourceSize)


        {
            AddComponent(new Arc(location.X, location.Y, waterSourceSize.width, waterSourceSize.height, 0, 360));

        }

    }



}
