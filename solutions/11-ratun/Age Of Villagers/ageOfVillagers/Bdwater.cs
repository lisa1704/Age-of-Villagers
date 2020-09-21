namespace ageOfVillagers
{
    internal class Bdwater : IShape
    {
        private int xLength = 24;
        private int yLength = 16;
        public string draw(int x, int y)
        {
            Line l1 = new Line(x - 12, y, x - 6, y + 6);
            Line l2 = new Line(x - 6, y + 6, x - 2, y + 7);
            Line l3 = new Line(x - 2, y + 7, x - 1, y + 3);
            Line l4 = new Line(x - 1, y + 3, x + 6, y + 8);
            Line l5 = new Line(x + 6, y + 8, x + 12, y + 2);
            Line l6 = new Line(x + 12, y + 2, x + 5, y - 7);
            Line l7 = new Line(x + 5, y - 7, x - 1, y - 2);
            Line l8 = new Line(x - 1, y - 2, x - 6, y + 8);
            Line l9 = new Line(x - 6, y + 8, x - 12, y);
            return l1.Draw() + l2.Draw() + l3.Draw() + l4.Draw() + l5.Draw() + l6.Draw() + l7.Draw() + l8.Draw() + l9.Draw();
        }
    }
}