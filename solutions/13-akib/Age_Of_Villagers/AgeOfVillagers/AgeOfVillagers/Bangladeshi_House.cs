using System;

namespace AgeOfVillagers

public class Bangladeshi_House : I_Shape
{
    public void Create_House(int x, int y)
    {
        Triangle bdh_triangle = new Triangle(x+8 , y, x, y+8, x-8, y);
        Rectangle bdh_rectangle = new Rectangle(x+8, y, x+8, y-8, x-8, y-8, x-8, y);

        bdh_triangle.Draw_Shape();
        bdh_rectangle.Draw_Shape();
    }
}
