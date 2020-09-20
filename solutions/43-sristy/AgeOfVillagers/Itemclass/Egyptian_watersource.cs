using System.Drawing;

namespace Age_of_villagers
{
    public class Egyptian_watersource: Compositeobj
    {
        public Egyptian_watersource(Point mptop)
        {
            Point mpmid = new Point(mptop.X - 6, mptop.Y - 6);
            AddComponent(new obj_arc(mpmid, 12, 12, 0, 360));
        }
    }
}
