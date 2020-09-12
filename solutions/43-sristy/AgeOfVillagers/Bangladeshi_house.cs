using System.Drawing;

namespace Age_of_villagers
{
    public class Bangladeshi_house: Compositeobj
    {
        public Bangladeshi_house(Point lptop)
        {
            Point rptop = new Point(lptop.X + 50, lptop.Y);
            Point lpbottom = new Point(lptop.X, lptop.Y + 25);
            Point rpbottom = new Point(lptop.X + 50, lptop.Y + 25);
            Point mptop = new Point(lptop.X + 25, lptop.Y - 25);
            AddComponent(new obj_rectangle(lptop, rptop, lpbottom, rpbottom));
            AddComponent(new obj_triangle(lptop, rptop, mptop));
        }
    }

    public class Bangladeshi_tree: Compositeobj
    {
        public Bangladeshi_tree(Point mptop)
        {
            Point lptop = new Point(mptop.X - 2, mptop.Y);
            Point rptop = new Point(mptop.X + 2, mptop.Y);
            Point lpbottom = new Point(mptop.X - 2, mptop.Y + 50);
            Point rpbottom = new Point(mptop.X + 2, mptop.Y + 50);
            AddComponent(new obj_arc(mptop, 50, 50, 0, 360));
            AddComponent(new obj_rectangle(lptop, rptop, lpbottom, rpbottom));
        }
    }

    public class Bangladeshi_watersource : Compositeobj
    {
        public Bangladeshi_watersource(Point p1)
        {
            Point p2 = new Point(p1.X - 25, p1.Y + 50);
            Point p3 = new Point(p1.X, p1.Y + 75);
            Point p4 = new Point(p1.X + 25, p1.Y + 50);
            Point p5 = new Point(p1.X + 50, p1.Y + 75);
            Point p6 = new Point(p1.X + 75, p1.Y + 25);
            Point p7 = new Point(p1.X + 50, p1.Y);
            Point p8 = new Point(p1.X + 25, p1.Y + 25);
            Point p9 = new Point(p1.X + 25, p1.Y);
            AddComponent(new obj_line(p1, p2));
            AddComponent(new obj_line(p2, p3));
            AddComponent(new obj_line(p3, p4));
            AddComponent(new obj_line(p4, p5));
            AddComponent(new obj_line(p5, p6));
            AddComponent(new obj_line(p6, p7));
            AddComponent(new obj_line(p7, p8));
            AddComponent(new obj_line(p8, p9));
            AddComponent(new obj_line(p9, p1));
        }
    }
}
