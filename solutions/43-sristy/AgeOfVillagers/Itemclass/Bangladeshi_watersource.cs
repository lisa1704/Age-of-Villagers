using System.Drawing;

namespace Age_of_villagers
{
    public class Bangladeshi_watersource : Compositeobj
    {
        public Bangladeshi_watersource(Point p1,int height,int weidth)
        {
            Point p2 = new Point(p1.X - (weidth/4), p1.Y + 11*(height/16));
            Point p3 = new Point(p1.X, p1.Y + 16);
            Point p4 = new Point(p1.X + (weidth / 4), p1.Y + 11 * (height / 16));
            Point p5 = new Point(p1.X + (weidth / 4), p1.Y + 16);
            Point p6 = new Point(p1.X + 2*(weidth / 3), p1.Y + 5 * (height / 16));
            Point p7 = new Point(p1.X + (weidth / 2), p1.Y);
            Point p8 = new Point(p1.X + (weidth / 4), p1.Y + 5 * (height / 16));
            Point p9 = new Point(p1.X + (weidth / 4), p1.Y);
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
