using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class InuitHunters : INation
    {
        private readonly Color color;
        private readonly String nation_name;

        public InuitHunters()
        {
            color = Color.White;
            nation_name = "Inuit Hunters";
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

    public class InuitHuntersHouse : CompositeShape
    {
        public InuitHuntersHouse(Point center)
        {
            Point innerCircle_topLeft = new Point(center.X - 3, center.Y - 6);
            Point innerCircle_bottomRight = new Point(center.X + 3, center.Y + 6);
            Point outerCircle_topLeft = new Point(center.X - 8, center.Y - 14);
            Point outerCircle_bottomRight = new Point(center.X + 8, center.Y + 14);

            AddComponent(new Arc(innerCircle_topLeft, innerCircle_bottomRight, 0, -180));
            AddComponent(new Arc(outerCircle_topLeft, outerCircle_bottomRight, 0, -180));
            AddComponent(new Line(new Point(center.X - 8, center.Y), new Point(center.X + 8, center.Y)));
        }
    }
}
