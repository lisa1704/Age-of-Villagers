using System.Drawing;

namespace Age_of_Villagers
{
    class Bdhouse : house
    {
        public Bdhouse(Point p, int length, int width) : base(p, length, width) { }
        public override void createHouse()
        {
            cs.addShape(new rectangle(p,length,width));
            Point p1 = p;
            Point p2 = new Point(p.X+length,p.Y);
            Point p3 = new Point(p.X + length / 2, p.Y - length/2);
            cs.addShape(new triangle(p1,p2,p3));
        }
        
    }
}
