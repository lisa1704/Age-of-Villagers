using System;

public class Egypthouse : IShape
{

    public void draw(int x, int y)
    {
        Triangle Eh1_triangle = new Triangle(x, y, x - 8, y + 2, x - 2, y + 16);
        Eh1_triangle.Draw();

        Triangle Eh2_triangle = new Triangle(x, y, x + 8, y + 5, x - 2, y + 16);
        Eh2_triangle.Draw();

        
    }

}

