namespace AgeOfVillagers
{
    internal class Arab_House : I_Shape
    {
        private string draw = "";

        public string Draw(int x, int y)
        {
            Triangle ah_triangle = new Triangle(x, y, x - 8, y, x - 4, y + 12);
            Rectangle ah_rectangle = new Rectangle(x, y, x + 8, y + 4, x, y + 16, x - 4, y + 12);

            draw = draw + ah_triangle.Draw_Shape();
            draw = draw + ah_rectangle.Draw_Shape();

            return draw;
        }
    }
}