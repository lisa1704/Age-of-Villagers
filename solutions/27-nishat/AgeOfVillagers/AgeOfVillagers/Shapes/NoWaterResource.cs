using System.Drawing;

namespace AgeOfVillagers
{
    public class NoWaterResource : VillageItem
    {
        private readonly Point point;

        public NoWaterResource(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            
        }

        public override Point GetPoint()
        {
            return point;
        }
    }

}
