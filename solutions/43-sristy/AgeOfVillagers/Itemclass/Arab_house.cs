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
        public Arab_house(Point mptop,int height,int weidth)
        {
            Point rptop = new Point(mptop.X +(weidth/4), mptop.Y+11*(height/16));
            Point lptop = new Point(mptop.X- (weidth / 4), mptop.Y + 11 * (height / 16));
            Point mpback = new Point(mptop.X + (weidth / 2), mptop.Y - 5 * (height / 16));
            Point rpback = new Point(mptop.X + 3*(weidth / 4), mptop.Y + 5 * (height / 16));
            AddComponent(new obj_triangle(lptop, rptop, mptop));
            AddComponent(new obj_rectangle(mptop, mpback, rptop, rpback));
        }
    }


}
