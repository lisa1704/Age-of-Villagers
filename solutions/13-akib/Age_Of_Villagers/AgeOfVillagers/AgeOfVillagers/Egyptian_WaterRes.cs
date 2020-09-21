namespace AgeOfVillagers
{
    internal class Egyptian_WaterRes : I_Shape
    {
		private int x_size = 12;
		private int y_size = 12;

		private string draw = "";

		public string Draw(int x, int y)
		{
			Circle ew_circle = new Circle(x, y, 6);

			draw = draw + ew_circle.Draw_Shape();

			return draw;
		}
	}
}