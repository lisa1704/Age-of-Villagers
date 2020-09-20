using System.Drawing;

namespace Age_of_villagers
{
    public class obj_triangle : Compositeobj
    {
        public obj_triangle(Point lptop, Point rptop, Point mptop)
        {
            AddComponent(new obj_line(lptop, rptop));
            AddComponent(new obj_line(lptop, mptop));
            AddComponent(new obj_line(rptop, mptop));
        }
    }
}
