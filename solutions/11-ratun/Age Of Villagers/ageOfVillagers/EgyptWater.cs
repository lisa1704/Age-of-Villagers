using System;

public class EgyptWater : Water
{
	private int Xaxis = 16;
	private int Yaxis = 16;
	public void CreateWater(int x, int y)
    {
		Circle c = new Circle(x, y, 8);
		c.Draw();
    }
}
