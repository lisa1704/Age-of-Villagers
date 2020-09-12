using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_villagers
{
    public class Inuit_house: Compositeobj
    {
        public Inuit_house(Point mptop)
        {
            Point outtop = new Point(mptop.X - 50, mptop.Y - 50);
            Point lpbottom = new Point(mptop.X - 75, mptop.Y);
            Point rpbottom = new Point(mptop.X + 75, mptop.Y);
            AddComponent(new obj_arc(mptop, 50, 50, 180, 180));
            AddComponent(new obj_arc(outtop, 150, 150, 180, 180));
            AddComponent(new obj_line(lpbottom, rpbottom));
        }
    }
}
