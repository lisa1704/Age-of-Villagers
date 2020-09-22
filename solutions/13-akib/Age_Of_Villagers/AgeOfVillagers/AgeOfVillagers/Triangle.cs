namespace AgeOfVillagers
{
    internal class Triangle
    {
        private int x1, y1, x2, y2, x3, y3;
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }
        public string Draw_Shape()
        {
            Lines line1 = new Lines(x1, y1, x2, y2);
            Lines line2 = new Lines(x2, y2, x3, y3);
            Lines line3 = new Lines(x3, y3, x1, y1);

            return line1.Draw_Shape() + line2.Draw_Shape() + line3.Draw_Shape();

        }
    }
}