using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    abstract class house:IShape
    {
        protected Point p;
        protected int length, width;
        protected compositeShape cs = new compositeShape();
        public house(Point p,int length, int width )
        {
            this.p = p;
            this.length = length;
            this.width = width;
        }
        public abstract void createHouse();

        public void draw(Graphics g, Pen pen)
        {
            this.createHouse();
            cs.draw(g, pen);
        }
    }

    class Bdhouse : house
    {
        public Bdhouse(Point p, int length, int width) : base(p, length, width) { }
        public override void createHouse()
        {
            cs.addShape(new rectangle(p,length,width));
            Point p1 = p;
            Point p2 = new Point(p.X+length,p.Y);
            Point p3 = new Point(p.X + length / 2, p.Y - width);
            cs.addShape(new triangle(p1,p2,p3));
        }
        
    }
}
