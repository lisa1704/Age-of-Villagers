using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
        private readonly Color color;
        private readonly String nation_name;

        public BangladeshiFarmers()
        {
            color = Color.GreenYellow;
            nation_name = "Bangladeshi Farmers";
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

    public class BangladeshiHouse : CompositeShape
    {
        public BangladeshiHouse(Point point)
        {
            Point top = point;
            Point baseTopLeft = new Point(top.X - 8, top.Y + 8);
            Point baseBottomRight = new Point(top.X + 8, top.Y + 16);

            AddComponent(new VShape(baseTopLeft, top, new Point(baseBottomRight.X, baseTopLeft.Y) ));
            AddComponent(new Rectangle(baseTopLeft, baseBottomRight));
        }
    }

    public class BangladeshiTree : CompositeShape
    {
        public BangladeshiTree(Point point)
        {  
            Point TopLeft = new Point(point.X - 1, point.Y + 4);
            Point BottomRight = new Point(point.X + 1, point.Y + 16);
            Point Circle_topLeft = new Point(point.X - 8, point.Y - 8);
            Point Circle_bottomRight = new Point(point.X + 8, point.Y + 8);

            AddComponent(new Arc(Circle_topLeft, Circle_bottomRight, 0, 360));
            AddComponent(new Rectangle(TopLeft, BottomRight));
        }
    }
}
