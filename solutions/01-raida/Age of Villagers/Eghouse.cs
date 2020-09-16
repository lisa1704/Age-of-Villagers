using System.Drawing;

namespace Age_of_Villagers
{
    class Eghouse:house
    {
        public Eghouse(Point p, int length, int width):base(p,length,width)
        { }
        
        public override void createHouse()
        {
            Point p1 = p;
            Point p2 = new Point(p.X + length, p.Y);
            Point p3 = new Point(p.X + length / 2, p.Y - length);
            cs.addShape(new triangle(p1, p2, p3));
            Point p4 = new Point(p2.X+width/2,p2.Y-width/2);
            cs.addShape(new triangle(p3, p4, p2));

        }
    }
}
