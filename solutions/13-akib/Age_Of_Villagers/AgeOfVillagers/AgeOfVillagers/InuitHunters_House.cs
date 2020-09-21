using System;

public class InuitHunters_House : I_Shape
{
	private string draw = "";

	public string Draw(int x, int y)
    {
        Half_Circle ihh_circle = new Half_Circle(x, y, 8);

        draw = draw + ihh_circle.Draw_Shape();

        return draw;
    }
}
