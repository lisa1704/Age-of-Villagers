using System;

namespace AgeOfVillagers

public class Circle : Shape
{
    private int x, y, radius;
	public Circle (int x, int y, int radius)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }
    public string Draw_Shape()
    {
        return "Drawing a Circle...";
    }
}
