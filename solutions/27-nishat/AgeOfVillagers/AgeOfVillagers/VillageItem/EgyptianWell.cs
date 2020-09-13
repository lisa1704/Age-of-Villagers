using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianWell : VillageItem
    {
        private readonly Point point;

        public EgyptianWell(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            Shape watersource = new WellShape(new Point(point.X - 6, point.Y - 6), new Point(point.X + 6, point.Y + 6));
            watersource.Draw(g, p);
        }

        public override Point GetPoint()
        {
            return point;
        }
    }

    public class EgyptianHouse : VillageItem
    {
        private readonly Point point;

        public EgyptianHouse(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            Shape house = new EgyptianHouseShape(new Point(point.X - 8, point.Y - 8), new Point(point.X + 8, point.Y + 8));
            house.Draw(g, p);
        }

        public override Point GetPoint()
        {
            return point;
        }
    }

    public class EgyptianTree : VillageItem
    {
        private readonly Point point;

        public EgyptianTree(Point point)
        {
            this.point = point;
        }

        public override void Draw(Graphics g, Pen p)
        {
            Shape tree = new EgyptianTreeShape(new Point(point.X - 8, point.Y - 12), new Point(point.X + 8, point.Y + 12));
            tree.Draw(g, p);
        }

        public override Point GetPoint()
        {
            return point;
        }
    }
}
