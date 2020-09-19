using System.Drawing;

namespace Age_of_Villagers
{
    public class circle : IShape
    {
        private readonly Point point;
        private readonly int radius;
        private IShape circleShape;
       public circle(Point P,int radius)
        {
            point = P;
            this.radius = radius;
        }
        
       public void draw(Graphics g, Pen pen)
       {
            circleShape=new arc(point, radius, 0, 360);
            circleShape.draw(g, pen);
        }
    }
}
