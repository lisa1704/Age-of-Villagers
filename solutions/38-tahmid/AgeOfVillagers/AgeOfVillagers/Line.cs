using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Line : Shape
    {
        Point start,end;
        Graphics g;
        Pen p;
        public Line()
        {
            
        }

        public void setDrawingElements(Graphics g, Pen p, Point start, Point end)
        {
            this.start = start;
            this.end = end;
            this.g = g;
            this.p = p;
        }
        public override void drawShape()
        {
            g.DrawLine(p, start, end);

        }
        
    }
}
