using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Age_of_Villagers.Models.Manifests
{
    class Arc : IShape
    {
        private Point location;
        private int width, height, startAngle, sweepAngle;
        public Arc(Point coordinates, int width, int height, int startAngle, int sweepAngle)
        {
            this.location = coordinates;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }
        public void Draw(Graphics gfx, Pen p)
        {
            gfx.DrawArc(p, location.X, location.Y, width, height, startAngle,sweepAngle);
        }
    }
}
