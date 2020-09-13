using System.Drawing;

namespace Age_of_Villagers
{
    class rectangle :IShape
    {
        private readonly int length;
        private readonly int height;
        private readonly Point p1,p2,p3,p4;
        
        private compositeShape cs = new compositeShape();
        public rectangle(Point p1,Point p2,Point p3,Point p4) {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }
        public void createRectangle()
        {
            cs.addShape(new line(p1,p2));
            cs.addShape(new line(p2,p3));
            cs.addShape(new line(p3, p4));
            cs.addShape(new line(p4, p1));
        }

        public void draw(Graphics g, Pen pen)
        {
            this.createRectangle();
            cs.draw(g,pen);
        }
    }
}
