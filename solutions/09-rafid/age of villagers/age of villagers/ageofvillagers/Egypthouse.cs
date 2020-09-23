using System;

public class Egypthouse : IShape
{

    private string draw = "";

    public string draw(int x, int y)
    {
        Triangle Eh1_triangle = new Triangle(x, y, x - 8, y + 2, x - 2, y + 16);
        draw = draw + Eh1_triangle.Draw_Shape();

        Triangle Eh2_triangle = new Triangle(x, y, x + 8, y + 5, x - 2, y + 16);
        draw = draw + Eh2_triangle.Draw_Shape();

        return draw;
    }

}

