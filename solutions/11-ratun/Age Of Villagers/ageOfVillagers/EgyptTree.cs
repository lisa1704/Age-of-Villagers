namespace ageOfVillagers
{
    internal class EgyptTree : IShape
    {
        public string draw(int x, int y)
        {
            Line l1 = new Line(x, y - 12, x - 6, y + 10);
            Line l2 = new Line(x, y - 12, x + 6, y + 10);
            Line l3 = new Line(x - 5, y + 8, x - 8, y + 6);
            Line l4 = new Line(x - 5, y + 8, x - 2, y + 12);
            Line l5 = new Line(x + 5, y + 8, x + 8, y + 6);
            Line l6 = new Line(x + 5, y + 8, x + 2, y + 12);
            return l1.Draw() + l2.Draw() + l3.Draw() + l4.Draw() + l5.Draw() + l6.Draw();
        }
    }
}