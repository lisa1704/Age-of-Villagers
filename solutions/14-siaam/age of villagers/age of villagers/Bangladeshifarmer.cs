using System.Drawing;

namespace age_of_villagers
{
    class Bangladeshifarmer : INation
    {
        
        Pen p = new Pen(Color.Red);
        private Color colorofbackground = Color.Green;
        public Color BgColor()
        {
            return colorofbackground;
        }

        public void drawHouse(Graphics g , Point point)
        {
            Point trianglePoint1 = new Point(point.X + 25, point.Y - 25);
            Point trianglePoint2 = new Point(point.X + 50, point.Y);
            Triangle triangle = new Triangle( point, trianglePoint1, trianglePoint2);
            triangle.draw(g,p);
           
        }
    }
}
