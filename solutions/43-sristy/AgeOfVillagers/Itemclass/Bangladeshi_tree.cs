using System.Drawing;

namespace Age_of_villagers
{
    public class Bangladeshi_tree: Compositeobj
    {
        public Bangladeshi_tree(Point mptop,int height,int weidth)
        {
            Point lptop = new Point(mptop.X - 1, mptop.Y);
            Point rptop = new Point(mptop.X + 1, mptop.Y);
            Point lpbottom = new Point(mptop.X - 1, mptop.Y + height-(weidth/2));
            Point rpbottom = new Point(mptop.X + 1, mptop.Y + height- (weidth / 2));
            Point mpmid = new Point(mptop.X - (weidth / 2), mptop.Y - (weidth / 2));
            AddComponent(new obj_arc(mpmid, weidth, weidth, 0, 360));
            AddComponent(new obj_rectangle(lptop, rptop, lpbottom, rpbottom));
        }
    }
}
