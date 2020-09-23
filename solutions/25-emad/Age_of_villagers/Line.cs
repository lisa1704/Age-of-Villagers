﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Age_of_villagers
{
    class Line : IShape
    {
         Point p1,p2;
         
        Pen pen;
        Graphics g;


        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;

        }
        

        public void Draw()
        {
            g.DrawLine(pen, p1, p2);
        }
    }
    
}