using System.Drawing;

namespace AgeOfVillagers
{
    public abstract class WaterResource : IVillageItem
    {
        private readonly Point point;
        public WaterResource(Point point)
        {
            this.point = point;
            getItemShape(point);
        }
        public Point getItemLocation()
        {
            return point;
        }
        public abstract CompositeShape getItemShape(Point point);
    }
    


}
