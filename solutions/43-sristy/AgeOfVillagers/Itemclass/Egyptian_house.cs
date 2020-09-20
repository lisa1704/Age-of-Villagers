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
        public Egyptian_house(Point lpbottom,int height,int weidth)
        {
            Point rpbottom = new Point(lpbottom.X + 11*(weidth/16), lpbottom.Y + 1 * (height / 16));
            Point mptop = new Point(lpbottom.X + 7 * (weidth / 16), lpbottom.Y - 15 * (height / 16));
            Point backbottom = new Point(lpbottom.X + weidth, lpbottom.Y - 3 * (height / 16));
            AddComponent(new obj_triangle(lpbottom, rpbottom, mptop));
            AddComponent(new obj_triangle(rpbottom, mptop, backbottom));
        }
    }
}
