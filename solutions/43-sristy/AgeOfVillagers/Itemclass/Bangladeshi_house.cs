using System.Drawing;

namespace Age_of_villagers
{
    public class Bangladeshi_house: Compositeobj
    {
        public Bangladeshi_house(Point lptop,int height, int weidth)
        {
            Point rptop = new Point(lptop.X + weidth, lptop.Y);
            Point lpbottom = new Point(lptop.X, lptop.Y + height/2);
            Point rpbottom = new Point(lptop.X + weidth, lptop.Y + height/2);
            Point mptop = new Point(lptop.X + weidth/2, lptop.Y - height/2);
            AddComponent(new obj_rectangle(lptop, rptop, lpbottom, rpbottom));
            AddComponent(new obj_triangle(lptop, rptop, mptop));
        }
    }
}
