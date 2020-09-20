using System.Drawing;

namespace Age_of_villagers
{
    public class obj_arc : IObject
    {
        private Point p1;
        private int x1, x2, r1, r2;
        public obj_arc(Point p1,int x1,int x2, int r1, int r2 )
        {
            this.p1 = p1;
            this.x1 = x1;
            this.x2 = x2;
            this.r1 = r1;
            this.r2 = r2;
        }

        public void paint(Pen p, Graphics g)
        {
            g.DrawArc(p, p1.X, p1.Y, x1, x2, r1, r2);
        }
    }
}
