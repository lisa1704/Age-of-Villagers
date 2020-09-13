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
}
