namespace ageOfVillagers
{
    internal class EgyptHouse : IShape
    {
        public string draw(int x, int y)
        {
            Triangle t1 = new Triangle(x, y + 8, x - 8, y - 4, x + 2, y - 8);
            Triangle t2 = new Triangle(x, y + 8, x + 8, y, x + 2, y - 8);
            return t1.Draw() + t2.Draw();
        }
    }
}