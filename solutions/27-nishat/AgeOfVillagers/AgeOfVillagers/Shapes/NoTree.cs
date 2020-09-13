using System.Drawing;

namespace AgeOfVillagers
{
    public class NoTree : VillageItem
    {
        private readonly Point point;

        public NoTree(Point point)
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
