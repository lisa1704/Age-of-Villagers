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
            Point outtop = new Point(mptop.X - 8, mptop.Y - 16);
            Point lpbottom = new Point(mptop.X - 8, mptop.Y);
            Point rpbottom = new Point(mptop.X + 8, mptop.Y);
            Point mpmid = new Point(mptop.X - 3, mptop.Y - 6);
            AddComponent(new obj_arc(mpmid, 6, 12, 180, 180));
            AddComponent(new obj_arc(outtop, 16, 32, 180, 180));
            AddComponent(new obj_line(lpbottom, rpbottom));
        }
    }
}
