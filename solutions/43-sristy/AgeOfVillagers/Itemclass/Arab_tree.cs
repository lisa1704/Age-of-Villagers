using System.Drawing;

namespace Age_of_villagers
{
    public class Arab_tree : Compositeobj
    {
        public Arab_tree(Point mptop,int height,int weidth)
        {
            Point lptop = new Point(mptop.X - 1, mptop.Y);
            Point rptop = new Point(mptop.X + 1, mptop.Y);
            Point lpbottom = new Point(mptop.X - 1, mptop.Y + 7*(height/12));
            Point rpbottom = new Point(mptop.X + 1, mptop.Y + 7 * (height / 12));
            Point p1 = new Point(mptop.X, mptop.Y - 5* (height / 12));
            Point p2 = new Point(mptop.X - 5 * (weidth / 16), mptop.Y - (height/3));
            Point p3 = new Point(mptop.X + 5*(weidth/16), mptop.Y - (height / 3));
            Point p4 = new Point(mptop.X - (weidth/2), mptop.Y - (height/8));
            Point p5 = new Point(mptop.X + (weidth / 2), mptop.Y - (height / 8));
            AddComponent(new obj_rectangle(lptop, rptop, lpbottom, rpbottom));
            AddComponent(new obj_line(mptop, p1));
            AddComponent(new obj_line(mptop, p2));
            AddComponent(new obj_line(mptop, p3));
            AddComponent(new obj_line(mptop, p4));
            AddComponent(new obj_line(mptop, p5));
        }
    }


}
