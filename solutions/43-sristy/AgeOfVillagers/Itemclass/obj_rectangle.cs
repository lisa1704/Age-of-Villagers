using System.Drawing;

namespace Age_of_villagers
{
    public class obj_rectangle : Compositeobj
    {
        public obj_rectangle(Point lptop, Point rptop, Point lpbottom, Point rpbottom)
        {
            AddComponent(new obj_line(lptop, rptop));
            AddComponent(new obj_line(lptop, lpbottom));
            AddComponent(new obj_line(rptop, rpbottom));
            AddComponent(new obj_line(lpbottom, rpbottom));
        }
    }
}
