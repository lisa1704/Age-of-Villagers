using System.Drawing;

namespace AgeOfVillagers
{
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
