using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class ArabBedouin : INation
    {
        private readonly Color color;
        private readonly String nation_name;

        public ArabBedouin()
        {
            color = Color.LightYellow;
            nation_name = "Arab Bedouin";
        }

        public object getHouse(Point point)
        {
            throw new NotImplementedException();
        }

        public string getNationName()
        {
            return nation_name;
        }

        public Color getTerrainColor()
        {
            return color;
        }

        public object getTree(Point point)
        {
            throw new NotImplementedException();
        }

        public object getWaterResource(Point point)
        {
            throw new NotImplementedException();
        }
    }

    public class ArabBedouinHouse : CompositeShape
    {
        public ArabBedouinHouse(Point point)
        {
            Point FrontTop = new Point(point.X - 0, point.Y + 6);
            Point baseFrontLeft = new Point(point.X - 8, point.Y + 6);
            Point baseFrontRight = new Point(point.X - 6, point.Y - 6);
            Point baseBackRight = new Point(point.X + 2, point.Y - 10);
            Point baseBackTop = new Point(point.X + 8, point.Y + 2);

            //IShape shape = new VShape(p1, mid, p2);
            //IShape shape2 = new Rectangle(p1, p2, p3, p4);
            AddComponent(new VShape(FrontTop, baseFrontLeft, baseFrontRight));
            AddComponent(new Rectangle(FrontTop, baseFrontRight, baseBackRight, baseBackTop));
        }
    }
}
