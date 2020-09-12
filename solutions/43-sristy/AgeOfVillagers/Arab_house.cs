﻿using System;
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
            Point rptop = new Point(mptop.X +25, mptop.Y+50);
            Point lptop = new Point(mptop.X-25, mptop.Y + 50);
            Point mpback = new Point(mptop.X + 50, mptop.Y - 25);
            Point rpback = new Point(mptop.X + 75, mptop.Y + 25);
            AddComponent(new obj_triangle(lptop, rptop, mptop));
            AddComponent(new obj_rectangle(mptop, mpback, rptop, rpback));
        }
    }

    public class Arab_tree : Compositeobj
    {
        public Arab_tree(Point mptop)
        {
            Point lptop = new Point(mptop.X - 2, mptop.Y);
            Point rptop = new Point(mptop.X + 2, mptop.Y);
            Point lpbottom = new Point(mptop.X - 2, mptop.Y + 50);
            Point rpbottom = new Point(mptop.X + 2, mptop.Y + 50);
            Point p1 = new Point(mptop.X, mptop.Y - 35);
            Point p2 = new Point(mptop.X - 25, mptop.Y - 25);
            Point p3 = new Point(mptop.X + 25, mptop.Y - 25);
            Point p4 = new Point(mptop.X - 35, mptop.Y - 10);
            Point p5 = new Point(mptop.X + 35, mptop.Y - 10);
            AddComponent(new obj_rectangle(lptop, rptop, lpbottom, rpbottom));
            AddComponent(new obj_line(mptop, p1));
            AddComponent(new obj_line(mptop, p2));
            AddComponent(new obj_line(mptop, p3));
            AddComponent(new obj_line(mptop, p4));
            AddComponent(new obj_line(mptop, p5));
        }
    }


}
