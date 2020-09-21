namespace AgeOfVillagers
{
    internal class Arab_Tree : I_Shape
    {
        private string draw = "";

        public string Draw(int x, int y)
        {
            Rectangle at_rectangle = new Rectangle(x + 1, y, x + 1, y - 12, x - 1, y - 12, x - 1, y);
            Lines at_line1 = new Lines(x, y, x, y + 12);
            Lines at_line2 = new Lines(x, y, x + 8, y + 3);
            Lines at_line3 = new Lines(x, y, x - 8, y + 3);
            Lines at_line4 = new Lines(x, y, x + 5, y + 8);
            Lines at_line5 = new Lines(x, y, x - 5, y + 8);

            draw = draw + at_rectangle.Draw_Shape();
            draw = draw + at_line1.Draw_Shape();
            draw = draw + at_line2.Draw_Shape();
            draw = draw + at_line3.Draw_Shape();
            draw = draw + at_line4.Draw_Shape();
            draw = draw + at_line5.Draw_Shape();

            return draw;
        }
    }
}