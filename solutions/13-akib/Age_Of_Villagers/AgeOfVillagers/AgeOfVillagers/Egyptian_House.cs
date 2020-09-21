namespace AgeOfVillagers
{
    internal class Egyptian_House : I_Shape
    {
        private string draw = "";

        public string Draw(int x, int y)
        {
            Triangle eh_triangle1 = new Triangle(x, y, x - 8, y + 2, x - 2, y + 16);
            Triangle eh_triangle2 = new Triangle(x, y, x + 8, y + 5, x - 2, y + 16);

            draw = draw + eh_triangle1.Draw_Shape();
            draw = draw + eh_triangle2.Draw_Shape();

            return draw;
        }
    }
}