using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    class BangladeshWaterResource:CompositeShape
    {
        Point point;

        public BangladeshWaterResource(Point point)
        {
            Point second_point = new Point(point.X + 4, point.Y - 4);
            Point third_point = new Point(second_point.X + 5, second_point.Y + 4);
            Point fourth_point = new Point(third_point.X + 4, point.Y - 6);
            Point fifth_point = new Point(fourth_point.X + 4, point.Y + 5);
            Point sixth_point = new Point(fifth_point.X + 4, point.Y - 4);
            Point seventh_point = new Point(sixth_point.X, sixth_point.Y + 8);
            Point eigth_point = new Point(seventh_point.X - 4, seventh_point.Y + 4);
            Point ninth_point = new Point(eigth_point.X - 4, seventh_point.Y + 4);
            Point tenth_point = new Point(ninth_point.X - 5, seventh_point.Y + 4);

            ShapePush(new Line(point,second_point));
            ShapePush(new Line(second_point,third_point));
            ShapePush(new Line(third_point,fourth_point));
            ShapePush(new Line(fourth_point,fifth_point));
            ShapePush(new Line(fifth_point,sixth_point));
            ShapePush(new Line(sixth_point,seventh_point));
            ShapePush(new Line(seventh_point,eigth_point));
            ShapePush(new Line(eigth_point,ninth_point));
            ShapePush(new Line(ninth_point,tenth_point));
            ShapePush(new Line(tenth_point,point));


        }

  

    }
}
