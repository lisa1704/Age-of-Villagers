using System.Drawing;

namespace Age_of_Villagers
{
    class Bdhouse : house
    {
        public Bdhouse(Point p, int length, int width) : base(p, length, width) { }
        public override void createHouse()
        {
            Point p2 = p;
            Point p3 = new Point(p2.X + length, p2.Y);
            Point p4 = new Point(p2.X, p.Y + length);
            Point p5 = new Point(p2.X + length, p2.Y + length);
            cs.addShape(new rectangle(p2, p3, p5, p4));
            Point p1 = p;
            p2 = new Point(p.X + length, p.Y);
            p3 = new Point(p.X + length / 2, p.Y - length / 2);
            cs.addShape(new triangle(p1, p2, p3));
        }
        
    }
}
