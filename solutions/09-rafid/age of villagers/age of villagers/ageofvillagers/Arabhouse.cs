using System;

public class Arabhouse : IShape
{
    public void CreateHouse(int x, int y)
    {
        Triangle arabh_triangle = new Triangle(x, y, x - 8, y, x - 4, y + 12);
        arabh_triangle.Draw_Shape();

        Rectangle arabh_rectangle = new Rectangle(x, y, x + 8, y + 4, x, y + 16, x - 4, y + 12);
        arabh_rectangle.Draw_Shape();
    }
}
