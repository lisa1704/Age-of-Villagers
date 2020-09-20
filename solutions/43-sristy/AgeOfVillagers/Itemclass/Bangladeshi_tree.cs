using System.Drawing;

namespace Age_of_villagers
{
    public class Bangladeshi_tree: Compositeobj
    {
        public Bangladeshi_tree(Point mptop)
        {
            Point lptop = new Point(mptop.X - 1, mptop.Y);
            Point rptop = new Point(mptop.X + 1, mptop.Y);
            Point lpbottom = new Point(mptop.X - 1, mptop.Y + 16);
            Point rpbottom = new Point(mptop.X + 1, mptop.Y + 16);
            Point mpmid = new Point(mptop.X - 8, mptop.Y - 8);
            AddComponent(new obj_arc(mpmid, 16, 16, 0, 360));
            AddComponent(new obj_rectangle(lptop, rptop, lpbottom, rpbottom));
        }
    }
}
