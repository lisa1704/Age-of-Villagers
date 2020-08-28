using System.Drawing;

namespace Age_Of_Villagers
{
    public class BangladeshiFarmers_WaterSource_ComplexPart : CompositeShape
    {



        public BangladeshiFarmers_WaterSource_ComplexPart(Point leftTop, Point topmid, Point mid, Point bottomMid, Point leftBottom)


        {
            AddComponent(new BangladeshiFarmers_WaterSource_MiniParts(leftTop, topmid, mid));
            AddComponent(new BangladeshiFarmers_WaterSource_MiniParts(mid, bottomMid, leftBottom));

        }

    }
    public class BangladeshiFarmers_WaterSource_MiniParts : CompositeShape
    {



        public BangladeshiFarmers_WaterSource_MiniParts(Point p1, Point p2, Point p3)


        {

            AddComponent(new Line(p1, p2));
            AddComponent(new Line(p2, p3));



        }

    }
    public class BangladeshiFarmersWaterSource : CompositeShape
    {



        public BangladeshiFarmersWaterSource(Point location, ItemSize waterSourceSize)


        {
            Point p1, p2, p3, p4, p5, p6, p7, p8, p9;
            p1 = new Point(location.X + waterSourceSize.width / 2, location.Y);

            p2 = new Point(p1.X - waterSourceSize.width / 4, location.Y);
            p3 = new Point(location.X, location.Y + waterSourceSize.height / 2);
            p4 = new Point(p2.X, location.Y + waterSourceSize.height);
            p5 = new Point(p4.X + waterSourceSize.height / 4, p3.Y + 4);
            p6 = new Point(p5.X + waterSourceSize.height / 4, p4.Y);
            p7 = new Point(location.X + waterSourceSize.width, p5.Y);
            p8 = new Point(p7.X - waterSourceSize.width / 3, location.Y);
            p9 = new Point(p1.X, p3.Y);





            AddComponent(new BangladeshiFarmers_WaterSource_ComplexPart(p1, p2, p3, p4, p5));
            AddComponent(new BangladeshiFarmers_WaterSource_ComplexPart(p5, p6, p7, p8, p9));
            AddComponent(new Line(p1, p9));




        }

    }




}
