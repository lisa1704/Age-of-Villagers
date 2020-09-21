using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class Arc : IShapeItem
    {
        private Point point_1;
        private Point point_2;

        public float x, y, start, height, width, sweep;

        public Arc(float x, float y, float width, float height, float start, float sweep)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.start = start;
            this.sweep = sweep;
        }

        public void Paint(Graphics g, Pen p)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawArc(pen, x, y, width, height, start, sweep);
        }
    }
}
