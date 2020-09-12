using System.Drawing;

namespace Age_of_Villagers
{
    class circle : IShape
    {
        private readonly Point point;
        private readonly float radius;
        private readonly compositeShape cs = new compositeShape();
        private IShape shape1,shape2;
       public circle(Point P,float radius)
        {
            point = P;
            this.radius = radius;
        }
        
        private void addShape()
        {
            shape1 = new arc(point, radius, 0, 180);
            cs.addShape(shape1);
            shape2 = new arc(point, radius, 0, -180);
            cs.addShape(shape2);
        }

       public void draw(Graphics g, Pen pen)
       {
            this.addShape();
            cs.draw(g, pen);

        }
    }
}
