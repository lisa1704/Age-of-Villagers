using System.Drawing;

namespace Age_of_Villagers
{
    class rectangle :IShape
    {
        private readonly int length;
        private readonly int height;
        private readonly Point p;
        
        private compositeShape cs = new compositeShape();
        public rectangle(Point p,int length,int height) {
            this.length = length;
            this.height = height;
            this.p = p;
        }
        public void createRectangle()
        {
            cs.addShape(new line(p, new Point(p.X + length, p.Y)));
            cs.addShape(new line(p,new Point(p.X, p.Y + height)));
            cs.addShape(new line(new Point(p.X, p.Y + height), new Point(p.X+length, p.Y + height)));
            cs.addShape(new line(new Point(p.X + length, p.Y), new Point(p.X + length, p.Y + height)));
        }

        public void draw(Graphics g, Pen pen)
        {
            this.createRectangle();
            cs.draw(g,pen);
        }
    }
}
