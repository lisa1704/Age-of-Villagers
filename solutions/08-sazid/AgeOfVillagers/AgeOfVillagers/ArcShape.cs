using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class ArcShape : IShape
    {
    //    private Point p1;
       // private Point p2;
        public float x;
        public float y;
        public float height;
        public float width;
        public float initAngle;
        public float sweepAngle;

        public ArcShape(float x, float y, float height, float width, float initAngle, float sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.initAngle = initAngle;
            this.sweepAngle = sweepAngle;
        }

        public void draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 1);
            g.DrawArc(pen, x, y, width, height, initAngle, sweepAngle);
        }
    }
}
