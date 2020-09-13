using System.Drawing;

namespace AgeOfVillagers
{
    public class Sampletree : VillageItem
    {
        private readonly Point point;

        public Sampletree(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p,point,new Point(point.X,point.Y-50));
        }

        public override Point GetPoint()
        {
            return point;
        }
    }
}
