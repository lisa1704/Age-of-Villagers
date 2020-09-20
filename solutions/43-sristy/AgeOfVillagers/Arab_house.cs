using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_villagers
{
    public class Arab_house:Compositeobj
    {
        public Arab_house(Point mptop)
        {
            Point rptop = new Point(mptop.X +4, mptop.Y+11);
            Point lptop = new Point(mptop.X-4, mptop.Y + 11);
            Point mpback = new Point(mptop.X + 8, mptop.Y - 5);
            Point rpback = new Point(mptop.X + 12, mptop.Y + 5);
            AddComponent(new obj_triangle(lptop, rptop, mptop));
            AddComponent(new obj_rectangle(mptop, mpback, rptop, rpback));
        }
    }

    public class Arab_tree : Compositeobj
    {
        public Arab_tree(Point mptop)
        {
            Point lptop = new Point(mptop.X - 1, mptop.Y);
            Point rptop = new Point(mptop.X + 1, mptop.Y);
            Point lpbottom = new Point(mptop.X - 1, mptop.Y + 16);
            Point rpbottom = new Point(mptop.X + 1, mptop.Y + 16);
            Point p1 = new Point(mptop.X, mptop.Y - 11);
            Point p2 = new Point(mptop.X - 8, mptop.Y - 8);
            Point p3 = new Point(mptop.X + 8, mptop.Y - 8);
            Point p4 = new Point(mptop.X - 11, mptop.Y - 3);
            Point p5 = new Point(mptop.X + 11, mptop.Y - 3);
            AddComponent(new obj_rectangle(lptop, rptop, lpbottom, rpbottom));
            AddComponent(new obj_line(mptop, p1));
            AddComponent(new obj_line(mptop, p2));
            AddComponent(new obj_line(mptop, p3));
            AddComponent(new obj_line(mptop, p4));
            AddComponent(new obj_line(mptop, p5));
        }
    }


}
