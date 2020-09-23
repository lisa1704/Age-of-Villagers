using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Arc : IShape
    {
        private readonly Point point1;
        private readonly Point point2;
        public int x, y, w, h, a1, a2;
        public Arc(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public void Draw(Graphics g)            
        {
            throw new NotImplementedException(); var pen = new Pen(Color.Black, 1);
            g.DrawArc(pen, x, y, w, h, a1, a2);
            
        }
    }
}
