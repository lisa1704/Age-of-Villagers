namespace AgeOfVillagers
{
    internal class Circle
    {
        private int x, y, radius;
        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public string Draw_Shape()
        {
            Arc arc_circle = new Arc(x-radius, y-radius, 2*radius, 2*radius, 0, 360);

            arc_circle.Draw_Shape();

            return "Drawing a circle...";
        }
    }
}