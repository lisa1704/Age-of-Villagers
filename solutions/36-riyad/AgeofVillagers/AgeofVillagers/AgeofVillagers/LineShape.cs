using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class LineShape : IShapeItem
    {

        private Point point_1;
        private Point point_2;

        public LineShape(Point point_1, Point point_2)
        {
            this.point_1 = point_1;
            this.point_2 = point_2;

        }
        public void Paint(Graphics g, Pen p)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, point_1, point_2);
        }
    }
}
