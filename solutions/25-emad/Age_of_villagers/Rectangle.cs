using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Age_of_villagers
{
    class Rectangles : IShape
    {

        Point p1,p2,p3,p4;
        Pen pen;
        Graphics g;
        public Rectangles(Graphics g, Pen pen, Point p1, Point p2, Point p3, Point p4)
        {

            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            
        }

        public void Draw()
        {
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p1, p3);
            g.DrawLine(pen, p3, p4);
            g.DrawLine(pen, p2, p4); 
        }

       
    }
}
