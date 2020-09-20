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
        public Inuit_house(Point mptop,int height,int weidth)
        {
            Point outtop = new Point(mptop.X - (weidth/2), mptop.Y - height);
            Point lpbottom = new Point(mptop.X - (weidth / 2), mptop.Y);
            Point rpbottom = new Point(mptop.X + (weidth / 2), mptop.Y);
            Point mpmid = new Point(mptop.X - 3*(weidth/16), mptop.Y - 3 * (height / 8));
            AddComponent(new obj_arc(mpmid, 3*(weidth/8), 3*(height/4), 180, 180));
            AddComponent(new obj_arc(outtop, weidth, height*2, 180, 180));
            AddComponent(new obj_line(lpbottom, rpbottom));
        }
    }
}
