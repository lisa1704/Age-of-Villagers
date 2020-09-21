using System;

namespace AgeOfVillagers

public class Arab_House
{
    public void Create_House(int x, int y)
    {
        Triangle ah_triangle = new Triangle(x, y, x - 8, y, x - 4, y + 12);
        Rectangle ah_rectangle = new Rectangle(x, y, x + 8, y + 4, x, y + 16, x - 4, y + 12);

        ah_triangle.Draw_Shape();
        ah_rectangle.Draw_Shape();
    }
}
