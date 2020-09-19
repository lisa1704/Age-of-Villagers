using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public abstract class river:IShape
    {
        protected Point p;
        
        protected compositeShape cs = new compositeShape();
        public river(Point p)
        {
            this.p = p;
        }
        public abstract void createRiver();

        public void draw(Graphics g, Pen pen)
        {
            this.createRiver();
            cs.draw(g, pen);
        }
    }
    class Bdriver : river
    {
        public Bdriver(Point p) : base(p) { }
        public override void createRiver()
        {
            Point p2 = new Point(p.X+50,p.Y);
            Point p3 = new Point(p.X + 15, p.Y + 15);
            Point p4 = new Point(p.X + 25,p.Y+10);
            Point p5 = new Point(p.X+35,p.Y + 15);
            Point p6 = new Point(p.X+10,p.Y-20);
            Point p7 = new Point(p.X + 20, p.Y - 30);
            Point p8 = new Point(p.X + 25, p.Y - 20);
            Point p9 = new Point(p.X + 45, p.Y -25);
            cs.addShape(new line(p,p3));
            cs.addShape(new line(p3, p4));
            cs.addShape(new line(p4, p5));
            cs.addShape(new line(p5, p2));
            cs.addShape(new line(p, p6));
            cs.addShape(new line(p6, p7));
            cs.addShape(new line(p7, p8));
            cs.addShape(new line(p8, p9));
            cs.addShape(new line(p9,p2));

        }
    }
}
