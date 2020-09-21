namespace AgeOfVillagers
{
    internal class Bangladeshi_WaterRes : I_Shape
    {
		private int x_size = 24;
		private int y_size = 16;

		private string draw = "";

		public string Draw(int x, int y)
		{
			Lines bdw_line1 = new Lines(x, y + 8, x, y + 1);
			Lines bdw_line2 = new Lines(x, y + 1, x + 7, y + 7);
			Lines bdw_line3 = new Lines(x + 7, y + 7, x + 12, y + 2);
			Lines bdw_line4 = new Lines(x + 12, y + 2, x + 9, y - 7);
			Lines bdw_line5 = new Lines(x + 9, y - 7, x + 1, y - 1);
			Lines bdw_line6 = new Lines(x + 1, y - 1, x - 3, y - 8);
			Lines bdw_line7 = new Lines(x - 3, y - 8, x - 12, y - 2);
			Lines bdw_line8 = new Lines(x - 12, y - 2, x - 5, y + 6);
			Lines bdw_line9 = new Lines(x - 5, y + 6, x, y + 8);

			draw = draw + bdw_line1.Draw_Shape();
			draw = draw + bdw_line2.Draw_Shape();
			draw = draw + bdw_line3.Draw_Shape();
			draw = draw + bdw_line4.Draw_Shape();
			draw = draw + bdw_line5.Draw_Shape();
			draw = draw + bdw_line6.Draw_Shape();
			draw = draw + bdw_line7.Draw_Shape();
			draw = draw + bdw_line8.Draw_Shape();
			draw = draw + bdw_line9.Draw_Shape();

			return draw;
		}
	}
}