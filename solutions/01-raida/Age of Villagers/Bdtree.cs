using System.Drawing;


namespace Age_of_Villagers
{
    class Bdtree : tree
    {
        public Bdtree(Point p, int length,int width) : base(p, length,width) { }
        public override void createTree()
        {
            cs.addShape(new circle(p, width));
            Point p2 = new Point(p.X-2 + width/2, p.Y+5 + width/2);
            Point p3 = new Point(p2.X + length / 6, p2.Y);
            Point p4 = new Point(p2.X, p2.Y + length);
            Point p5 = new Point(p2.X + length / 6, p2.Y + length);
            cs.addShape(new rectangle(p2, p3,p5,p4));
        }
    }
}
