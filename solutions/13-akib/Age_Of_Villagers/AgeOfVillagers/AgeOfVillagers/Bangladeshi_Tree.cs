namespace AgeOfVillagers
{
    internal class Bangladeshi_Tree : I_Shape
    {
        private string draw = "";

        public string Draw(int x, int y)
        {
            Circle bdt_circle = new Circle(x, y + 1, 8);
            Rectangle bdt_rectangle = new Rectangle(x + 1, y, x + 1, y - 12, x - 1, y - 12, x - 1, y);

            draw = draw + bdt_circle.Draw_Shape();
            draw = draw + bdt_rectangle.Draw_Shape();
            return draw;
        }
    }
}