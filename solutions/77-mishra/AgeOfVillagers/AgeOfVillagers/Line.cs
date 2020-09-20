using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class Line : IShape
    {
        private Point p1;
        private Point p2;

        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public void draw(Point p, Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, p1, p2);
        }
    }
}
