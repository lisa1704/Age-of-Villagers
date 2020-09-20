using System.Drawing;

namespace Age_of_villagers
{
    public class Egyptian_tree: Compositeobj
    {
        public Egyptian_tree(Point mptop,int height,int weidth)
        {
            Point p1 = new Point(mptop.X + 3*(weidth / 16), mptop.Y - 5*(height/12));
            Point p2 = new Point(mptop.X - 3 * (weidth / 16), mptop.Y - 5 * (height / 8));
            Point p3 = new Point(mptop.X + (weidth/2), mptop.Y - 5*(height/6));
            Point p4 = new Point(mptop.X + 3 * (weidth / 16), mptop.Y - 5 * (height / 6));
            Point p5 = new Point(mptop.X + (weidth / 2), mptop.Y - 13*(height/24));
            Point p6 = new Point(mptop.X - 1 * (weidth / 16), mptop.Y - height);
            Point p7 = new Point(mptop.X - 5 * (weidth / 16), mptop.Y - height);
            Point p8 = new Point(mptop.X - (weidth / 2), mptop.Y - 5 * (height / 6));
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
