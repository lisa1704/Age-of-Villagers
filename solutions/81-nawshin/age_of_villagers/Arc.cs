using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{ 
    public class Arc : IShape
    {
        private readonly Point pt;
        private readonly int w, h, a1, a2;
        public Arc(Point pt,int w,int h,int a1,int a2)
        {
            this.pt = pt;
            this.w = w;
            this.h = h;
            this.a1 = a1;
            this.a2 = a2;
        }

        public void draw(Graphics g)
        {
            Pen p = new Pen(Color.DarkBlue);
            g.DrawArc(p, pt.X - 25, pt.Y - 25, w, h, a1, a2);
        }
    }
}
