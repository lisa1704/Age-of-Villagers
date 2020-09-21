namespace ageOfVillagers
{
    internal class HalfCircle
    {
        private int x, y, radius;
        public HalfCircle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public string Draw()
        {
            return "Drawing a half circle. ";
        }
    }
}