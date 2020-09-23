using System;

public class Egyptwaters : IShape
{
    
	private int x_axis = 12;
	private int y_axis = 12;

	private string draw = "";

	public string draw(int x, int y)
	{
		Circle Ewcircle = new Circle(x, y, 6);

		draw = draw + Ewcircle.draw_Shape();

		return draw;
	}
}
