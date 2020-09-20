using System.Drawing;

namespace Age_of_villagers
{
    public class Egyptian_tree: Compositeobj
    {
        public Egyptian_tree(Point mptop)
        {
            Point p1 = new Point(mptop.X + 3, mptop.Y - 10);
            Point p2 = new Point(mptop.X - 3, mptop.Y - 15);
            Point p3 = new Point(mptop.X + 8, mptop.Y - 20);
            Point p4 = new Point(mptop.X + 3, mptop.Y - 20);
            Point p5 = new Point(mptop.X + 8, mptop.Y - 13);
            Point p6 = new Point(mptop.X - 1, mptop.Y - 24);
            Point p7 = new Point(mptop.X - 5, mptop.Y - 24);
            Point p8 = new Point(mptop.X - 8, mptop.Y - 20);
            AddComponent(new obj_line(mptop, p1));
            AddComponent(new obj_line(mptop, p2));
            AddComponent(new obj_line(p1, p3));
            AddComponent(new obj_line(p1, p4));
            AddComponent(new obj_line(p1, p5));
            AddComponent(new obj_line(p2, p6));
            AddComponent(new obj_line(p2, p7));
            AddComponent(new obj_line(p2, p8));
        }
    }
}
