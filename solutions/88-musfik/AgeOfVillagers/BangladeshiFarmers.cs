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
            return new BangladeshiHouse(point);
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
            return new BangladeshiTree(point);
        }

        public object getWaterResource(Point point)
        {
            return new Bangladeshi_WaterSource(point);
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
    public class Bangladeshi_WaterSource : CompositeShape
    {
        public Bangladeshi_WaterSource(Point point)
        {
            Point one = new Point(point.X - 13, point.Y );
            Point two = new Point(point.X - 7, point.Y - 10);
            Point three = new Point(point.X - 2, point.Y - 11);
            Point four = new Point(point.X - 2, point.Y - 6);
            Point five = new Point(point.X + 4, point.Y - 12);
            Point six = new Point(point.X + 10, point.Y - 7);
            Point seven = new Point(point.X + 7, point.Y + 3);
            Point eight = point;
            Point nine = new Point(point.X - 6, point.Y + 6);

            AddComponent(new VShape(one, two, three));
            AddComponent(new VShape(three, four, five));
            AddComponent(new VShape(five, six, seven));
            AddComponent(new VShape(seven, eight, nine));
            AddComponent(new Line(nine, one));
        }
    }
}
