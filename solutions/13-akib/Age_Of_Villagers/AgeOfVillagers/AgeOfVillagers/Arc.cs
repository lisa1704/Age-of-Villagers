namespace AgeOfVillagers
{
    internal class Arc
    {
        private int x, y, height, weight, start_angle, finish_angle;
        public Arc(int x, int y, int height, int weight, int start_angle, int finish_angle)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.weight = weight;
            this.start_angle = start_angle;
            this.finish_angle = finish_angle;
        }
        public string Draw_Shape()
        {
            return "Drawing a Line...";
        }
    }
}