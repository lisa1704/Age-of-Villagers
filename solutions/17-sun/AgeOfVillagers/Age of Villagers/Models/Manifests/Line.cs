using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Models.Manifests
{
    class Line : IShape
    {
        private Point a;
        private Point b;
        public Line (Point a , Point b)
        {
            this.a = a;
            this.b = b;
        }
        public void Draw(Graphics gfx, Pen p)
        {
            gfx.DrawLine(p, a, b);
        }
    }
}
