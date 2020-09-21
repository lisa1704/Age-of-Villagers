namespace AgeOfVillagers
{
    internal class Bangladeshi_House : I_Shape
    {
        private string draw = "";

        public string Draw(int x, int y)
        {
            Triangle bdh_triangle = new Triangle(x + 8, y, x, y + 8, x - 8, y);
            Rectangle bdh_rectangle = new Rectangle(x + 8, y, x + 8, y - 8, x - 8, y - 8, x - 8, y);

            draw = draw + bdh_triangle.Draw_Shape();
            draw = draw + bdh_rectangle.Draw_Shape();
            return draw;
        }
    }
}