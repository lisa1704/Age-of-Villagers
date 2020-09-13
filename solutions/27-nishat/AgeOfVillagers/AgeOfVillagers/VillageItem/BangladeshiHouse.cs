using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiHouse : VillageItem
    {
        private readonly Point point;

        public BangladeshiHouse(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            Shape house = new BangladeshiHouseShape(new Point(point.X, point.Y - 8), new Point(point.X-8, point.Y), new Point(point.X+8, point.Y + 8));
            house.Draw(g, p);
        }

        public override Point GetPoint()
        {
            return point;
        }
    }

    public class BangladeshiTree : VillageItem
    {
        private readonly Point point;

        public BangladeshiTree(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            Shape tree = new BangladeshiTreeShape(new Point(point.X-8, point.Y - 12), new Point(point.X + 8, point.Y+12));
            tree.Draw(g, p);
        }

        public override Point GetPoint()
        {
            return point;
        }
    }

    public class BangladeshiPond : VillageItem
    {
        private readonly Point point;

        public BangladeshiPond(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            Shape watersource = new BangladeshiPondShape(new Point(point.X - 12, point.Y - 8), new Point(point.X + 12, point.Y + 8));
            watersource.Draw(g, p);
        }

        public override Point GetPoint()
        {
            return point;
        }
    }
}
