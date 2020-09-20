using System.Drawing;

namespace Age_of_villagers
{
    public class Bangladeshi_house: Compositeobj
    {
        public Bangladeshi_house(Point lptop)
        {
            Point rptop = new Point(lptop.X + 16, lptop.Y);
            Point lpbottom = new Point(lptop.X, lptop.Y + 8);
            Point rpbottom = new Point(lptop.X + 16, lptop.Y + 8);
            Point mptop = new Point(lptop.X + 8, lptop.Y - 8);
            AddComponent(new obj_rectangle(lptop, rptop, lpbottom, rpbottom));
            AddComponent(new obj_triangle(lptop, rptop, mptop));
        }
    }
}
