using System.Drawing;


namespace Age_of_Villagers
{
    class Egtree : tree
    {
        public Egtree(Point p,int length, int width) : base(p, length, width) { }
        public override void createTree()
        {
            Point p2 = new Point(p.X - width, p.Y - length);
            Point p3= new Point(p.X + width, p.Y - length);
            cs.addShape(new line(p, p2));
            cs.addShape(new line(p, p3));
            Point p4 = new Point(p2.X - width, p2.Y - width);
            Point p5= new Point(p2.X - width/2, p2.Y - width - 10);
            Point p6 = new Point(p2.X, p2.Y - width-10);
            cs.addShape(new line(p2,p4));
            cs.addShape(new line(p2,p5));
            cs.addShape(new line(p2,p6));
            p4 = new Point(p3.X +width, p3.Y - width);
             p5 = new Point(p3.X + width / 2, p3.Y - width - 10);
            p6 = new Point(p3.X, p3.Y - width - 10);
            cs.addShape(new line(p3, p4));
            cs.addShape(new line(p3, p5));
            cs.addShape(new line(p3, p6));
        }
    }
}
