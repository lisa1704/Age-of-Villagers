using System;

public class Bdwater : IShape
{
	private int x_size = 24;
	private int y_size = 16;

	private string draw = "";

	public string draw(int x, int y)
	{
		Lines Bdw_l1 = new Lines(x, y + 8, x, y + 1);
		draw = draw + Bdw_l1.Draw_Shape();

		Lines Bdw_l2 = new Lines(x, y + 1, x + 7, y + 7);
		draw = draw + Bdw_l2.Draw_Shape();

		Lines Bdw_l3 = new Lines(x + 7, y + 7, x + 12, y + 2);
		draw = draw + Bdw_l3.Draw_Shape();

		Lines Bdw_l4 = new Lines(x + 12, y + 2, x + 9, y - 7);
		draw = draw + Bdw_l4.Draw_Shape();

		Lines Bdw_l5 = new Lines(x + 9, y - 7, x + 1, y - 1);
		draw = draw + Bdw_l5.Draw_Shape();

		Lines Bdw_l6 = new Lines(x + 1, y - 1, x - 3, y - 8);
		draw = draw + Bdw_l6.Draw_Shape();

		Lines Bdw_l7 = new Lines(x - 3, y - 8, x - 12, y - 2);
		draw = draw + Bdw_l7.Draw_Shape();

		Lines Bdw_l8 = new Lines(x - 12, y - 2, x - 5, y + 6);
		draw = draw + Bdw_l8.Draw_Shape();

		Lines Bdw_l9 = new Lines(x - 5, y + 6, x, y + 8);
		draw = draw + Bdw_l9.Draw_Shape();

		return draw;
	}
}
