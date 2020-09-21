using System;

namespace AgeOfVillagers

public class Egyptian_House
{
	public void Create_House(int x, int y)
    {
        Triangle eh_triangle1 = new Triangle(x, y, x - 8, y + 2, x - 2, y + 16);
        Triangle eh_triangle2 = new Triangle(x, y, x + 8, y + 5, x - 2, y + 16);

        eh_triangle1.Draw_Shape();
        eh_triangle2.Draw_Shape();
    }
}
