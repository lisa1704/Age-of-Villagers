using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public abstract class house:IShape
    {
        protected Point p;
        protected int length, width;
        protected ShapeCombine sc = new ShapeCombine();

        public house(Point p,int length, int width )
        {
            this.p = p;
            this.l = length;
            this.w = width;
        }
        public abstract void BuildHouse();

        public void Draw(Graphics grap, Pen pen)
        {
            this.BuildHouse();
            sc.Draw(grap, pen);
        }
    }
}