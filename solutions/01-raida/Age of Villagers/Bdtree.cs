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
            cs.addShape(new rectangle(p2, length/6, length));
        }
    }
}
