using System.Drawing;

namespace Age_of_villagers
{
    public class Egyptian_watersource: Compositeobj
    {
        public Egyptian_watersource(Point mptop,int height,int weidth)
        {
            Point mpmid = new Point(mptop.X - (weidth/2), mptop.Y - (height/2));
            AddComponent(new obj_arc(mpmid, weidth, height, 0, 360));
        }
    }
}
