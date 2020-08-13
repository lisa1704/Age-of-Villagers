using System.Drawing;

namespace Age_Of_Villagers
{
    public class Arc : IShapes
    {
        public int x ,y, width, height, startAngle, sweepAngle;




        public Arc(int x, int y, int width,int height,int startAngle,int sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;

        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawArc(pen, x, y, width, height, startAngle, sweepAngle);
         
        }

        public Rectangle GetBBox()
        {
            throw new System.NotImplementedException();
        }

    
    }



}
