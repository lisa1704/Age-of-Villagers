using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class triangle:IShape
    {
        
        private readonly Point point1,point2,point3;

        private compositeShape cs = new compositeShape();
        public triangle(Point p1,Point p2,Point p3)
        {
            point1 = p1;
            point2 = p2;
            point3 = p3;
        }

        public void createTriangle()
        {
            cs.addShape(new line(point1,point2));
            cs.addShape(new line(point2, point3));
            cs.addShape(new line(point1, point3));
        }
        public void draw(Graphics g, Pen pen)
        {
            this.createTriangle();
            cs.draw(g, pen);
        }
    }

}
