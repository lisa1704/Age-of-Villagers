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
        public void draw()
        {
            DrawArc(pen, x, y, width, height, startAngle, sweepAngle);
        }
    }
}
