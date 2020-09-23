using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace ageofvillagers
{
    class Arc
    { 
    
        Pen pen;
        private int x, y;
        int height, width, startAngle, sweepAngle;
        private object pen1;
        private int v1;
        private int v2;
        private int v3;
        private int v4;
        private int v5;
        private int v6;

        public Arc(object pen1, int v1, int v2, int v3, int v4, int v5, int v6)
        {
            this.pen1 = pen1;
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
        }

        public void DrawArc(System.Drawing. Pen pen, int x, int y, int width, int height, int startAngle, int sweepAngle)
        {
            this.pen = pen;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }
        public void Draw()
        {
            DrawArc(pen, x, y, width, height, startAngle, sweepAngle);
        }
    }
}
