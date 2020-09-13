using System.Drawing;

namespace Age_of_Villagers
{
    class igloo : house
    {
        public igloo(Point p,int length,int width) : base(p, length, width) { }
        public override void createHouse()
        {
            cs.addShape(new arc(p, length, 0,- 180));
            Point p2 = new Point(p.X+4+length/4,p.Y+4+length/4);
            cs.addShape(new arc(p2, width, 0, -180));
            Point p3 = new Point(p.X, p.Y + length/2);
            Point p4= new Point(p.X+length, p.Y + length/2);
            cs.addShape(new line(p3, p4));
        }
    }
}