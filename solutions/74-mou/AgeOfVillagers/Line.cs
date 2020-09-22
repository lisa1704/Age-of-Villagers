﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Line : IShapes
    {
       private readonly Point p1, p2;
       public Line(Point p1, Point p2) 
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public void DrawShapes(Graphics gr,Pen pen)
        {
            gr.DrawLine(pen,p1, p2);
        }
    }
}
