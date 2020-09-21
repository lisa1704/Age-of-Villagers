using System;

namespace AgeOfVillagers

public class Egyptian_WaterRes : I_Shape
{
	private int x_size = 12;
	private int y_size = 12;

	public void Create_WaterResource(int x, int y)
    {
		Circle ew_circle = new Circle(x, y, 6);

		ew_circle.Draw_Shape();
    }

}
