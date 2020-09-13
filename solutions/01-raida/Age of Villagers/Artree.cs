using System.Drawing;

namespace Age_of_Villagers
{
    class Artree : tree
    {
        public Artree(Point p, int length ,int width) : base(p,length,width){ }
        public override void createTree()
        {
            Point p2 = new Point(p.X  + width / 2, p.Y + width / 2);
            Point p3 = new Point(p2.X + length / 6, p2.Y);
            Point p4 = new Point(p2.X, p2.Y + length);
            Point p5 = new Point(p2.X + length / 6, p2.Y + length);
            cs.addShape(new rectangle(p2, p3, p5, p4));
            p3 = new Point(p2.X - length / 2, p2.Y - width);
            cs.addShape(new line(p2,p3 ));
            p4 = new Point(p2.X + 5, p2.Y);
            p5 = new Point(p4.X - length / 2, p4.Y - width-10);
            cs.addShape(new line(p4,p5));
            Point p6 = p4;
            Point p7 = new Point(p6.X , p6.Y-width-15);
            cs.addShape(new line(p6, p7));
            Point p8 = new Point(p2.X + 5, p2.Y);
            Point p9 = new Point(p4.X + length / 2, p4.Y - width - 10);
            cs.addShape(new line(p8, p9));
            p3 = new Point(p2.X + length / 6, p2.Y);
            Point p10 = new Point(p3.X + length / 2, p2.Y - width);
            cs.addShape(new line(p3, p10));


        }
    }
}
