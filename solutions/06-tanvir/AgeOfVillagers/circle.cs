using System.Drawing;



namespace AgeOfVillagers.Shapes
{
    class Circle : IShape
    {
        private Point x;
        private int y, width, height, radius;
        Graphics grap;
        Pen pen;


        public Circle(Graphics grap, Pen pen, Point x, int y, int width, int height, int radius)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.radius = radius;
            this.g = grap;
            this.pen = pen;
        }
        public void CreateShape()
        {
            g.DrawArc(pen, x.X - 25, x.Y - 25, y, width, height, radius);
        }
    }
}