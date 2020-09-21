namespace ageOfVillagers
{
    internal class Rectangle
    {
        private string status = "";
        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            Line l1 = new Line(x1, y1, x2, y2);
            Line l2 = new Line(x2, y2, x3, y3);
            Line l3 = new Line(x3, y3, x4, y4);
            Line l4 = new Line(x4, y4, x1, y1);
            status = l1.Draw() + l2.Draw() + l3.Draw()+ l4.Draw();
        }
        public string Draw()
        {
            return status;
        }
    }
}