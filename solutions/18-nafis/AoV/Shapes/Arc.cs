using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoV.Shapes
{
    class Arc : IShape
    {
        private float x, y, width, height;
        private float start, sweep;
        public Arc(float x, float y, float width, float height, float start, float sweep)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.start = start;
            this.sweep = sweep;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            g.DrawArc(pen, x, y, height, width, start, sweep);
        }
    }
}
