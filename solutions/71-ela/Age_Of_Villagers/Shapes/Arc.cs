using System.Drawing;

namespace Age_Of_Villagers
{
    public class Arc : IShapes
    {
        public int x ,y, width, height, startAngle, sweepAngle;
        SizeF size;
        PointF point;
        RectangleF rectangle;




        public Arc(int x, int y, int width,int height,int startAngle,int sweepAngle)
        {
            this.point = new PointF(x, y);
            this.size = new SizeF(width, height);
            this.rectangle = new RectangleF(point, size);
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;

        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawArc(pen, rectangle, startAngle, sweepAngle);
         
        }

        public Rectangle GetBBox()
        {
            Point topLeft = new Point((int)rectangle.Left,(int)rectangle.Top);
            Point topRight = new Point((int)rectangle.Right, (int)rectangle.Top);
            Point bottomLeft = new Point((int)rectangle.Left, (int)rectangle.Bottom);
            Point bottomRight = new Point((int)rectangle.Right, (int)rectangle.Bottom);


            Rectangle bbox = new Rectangle(topLeft,topRight,bottomLeft,bottomRight);
            return bbox;

           
        }

    
    }



}
