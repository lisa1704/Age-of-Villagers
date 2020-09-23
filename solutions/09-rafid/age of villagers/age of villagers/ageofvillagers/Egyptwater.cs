using System;

public class Egyptwaters : IShape
{
    
	private int x_axis = 12;
	private int y_axis = 12;

	

	public void draw(int x, int y)
	{
		Circle Ewcircle = new Circle(x, y, 6);

		Ewcircle.Draw();

		
	}
}
