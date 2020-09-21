namespace AgeOfVillagers
{
    internal class Egyptian_Tree : I_Shape
    {
        private string draw = "";

        public string Draw(int x, int y)
        {
            Lines et_line1 = new Lines(x, y, x + 3, y + 13);
            Lines et_line2 = new Lines(x, y, x - 4, y + 16);
            Lines et_line11 = new Lines(x + 3, y + 13, x + 2, y + 24);
            Lines et_line12 = new Lines(x + 3, y + 13, x + 6, y + 24);
            Lines et_line13 = new Lines(x + 3, y + 13, x + 8, y + 23);
            Lines et_line21 = new Lines(x - 4, y + 16, x - 3, y + 24);
            Lines et_line22 = new Lines(x - 4, y + 16, x - 6, y + 22);
            Lines et_line23 = new Lines(x - 4, y + 16, x - 8, y + 21);

            draw = draw + et_line1.Draw_Shape();
            draw = draw + et_line2.Draw_Shape();
            draw = draw + et_line11.Draw_Shape();
            draw = draw + et_line12.Draw_Shape();
            draw = draw + et_line13.Draw_Shape();
            draw = draw + et_line21.Draw_Shape();
            draw = draw + et_line22.Draw_Shape();
            draw = draw + et_line23.Draw_Shape();

            return draw;
        }
    }
}