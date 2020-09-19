using System.Drawing;

namespace Age_of_Villagers
{
    public class Arhouse : house
    {
        public Arhouse(Point p, int length, int width) : base(p, length, width) { }
        public override void createHouse()
        {
            Point p1 = p;
            Point p2 = new Point(p.X + length, p.Y);
            Point p3 = new Point(p.X + length/2 , p.Y - length);
            cs.addShape(new triangle(p1, p2,p3));
            Point p4 = new Point(p3.X+width,p3.Y- width);
            Point p5 = new Point(p2.X + width, p2.Y - width);
            cs.addShape(new rectangle(p3,p4,p5,p2));
           
        }
    }
}
