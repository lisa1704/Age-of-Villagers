using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class Arc : IShape
    {
        private Point point_1;
        private Point point_2;

        public int x, y, height, width, start, sweep;

        public Arc()
        {

        }

        public void Paint(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawArc(pen, x, y, width, height, start, sweep);
        }
    }
}
