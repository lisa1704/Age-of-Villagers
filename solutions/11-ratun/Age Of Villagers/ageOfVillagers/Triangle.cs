namespace ageOfVillagers
{
    internal class Triangle
    {
        private string status = "";
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Line l1 = new Line(x1, y1, x2, y2);
            Line l2 = new Line(x2, y2, x3, y3);
            Line l3 = new Line(x3, y3, x1, y1);
            l1.Draw(g,p);
            l2.Draw(g,p);
            l3.Draw(g,p);
            //status = l1.Draw() + l2.Draw() + l3.Draw();
        }
        public string Draw()
        {
            return status;
        }
    }
}