using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_villagers
{
    public class Egyptian_house : Compositeobj 
    {
        public Egyptian_house(Point lpbottom)
        {
            Point rpbottom = new Point(lpbottom.X + 65, lpbottom.Y + 15);
            Point mptop = new Point(lpbottom.X + 50, lpbottom.Y - 85);
            Point backbottom = new Point(lpbottom.X + 90, lpbottom.Y - 25);
            AddComponent(new obj_triangle(lpbottom, rpbottom, mptop));
            AddComponent(new obj_triangle(rpbottom, mptop, backbottom));
        }
    }
    public class Egyptian_tree: Compositeobj
    {
        public Egyptian_tree(Point mptop)
        {
            Point p1 = new Point(mptop.X + 15, mptop.Y - 25);
            Point p2 = new Point(mptop.X - 15, mptop.Y - 35);
            Point p3 = new Point(mptop.X + 40, mptop.Y - 50);
            Point p4 = new Point(mptop.X + 15, mptop.Y - 50);
            Point p5 = new Point(mptop.X + 40, mptop.Y - 30);
            Point p6 = new Point(mptop.X - 5, mptop.Y - 60);
            Point p7 = new Point(mptop.X - 25, mptop.Y - 60);
            Point p8 = new Point(mptop.X - 40, mptop.Y - 50);
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
    public class Egyptian_watersource: Compositeobj
    {
        public Egyptian_watersource(Point mptop)
        {
            AddComponent(new obj_arc(mptop, 50, 50, 0, 360));
        }
    }
}
