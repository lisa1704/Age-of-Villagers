using System.Drawing;

namespace Age_of_villagers
{
    public class obj_line: IObject
    {
        private Point p1, p2;
        public obj_line(Point p1,Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public void paint(Pen p, Graphics g)
        {
            g.DrawLine(p, p1, p2);
        }
    }
}
