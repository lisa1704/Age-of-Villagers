using System.Drawing;

namespace AgeOfVillagers.Shapes
{
    class Line : IShape
    {
        Point p1;
        Point p2;
        Pen pen;
        Graphics g;
        public Line(Graphics g, Pen pen, Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.pen = pen;
            this.g = g;
        }
        public void DrawShape()
        {
            g.DrawLine(pen, p1, p2);
        }
    }
}
