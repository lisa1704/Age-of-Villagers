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


}
