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
            Point outtop = new Point(mptop.X - 12, mptop.Y - 12);
            Point lpbottom = new Point(mptop.X - 12, mptop.Y);
            Point rpbottom = new Point(mptop.X + 12, mptop.Y);
            Point mpmid = new Point(mptop.X - 4, mptop.Y - 4);
            AddComponent(new obj_arc(mpmid, 8, 8, 180, 180));
            AddComponent(new obj_arc(outtop, 24, 24, 180, 180));
            AddComponent(new obj_line(lpbottom, rpbottom));
        }
    }
}
