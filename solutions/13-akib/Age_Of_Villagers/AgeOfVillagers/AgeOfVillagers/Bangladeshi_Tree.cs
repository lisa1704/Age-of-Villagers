using System;

namespace AgeOfVillagers

public class Bangladeshi_Tree : I_Shape
{
	public void Create_Tree(int x, int y)
    {
        Circle bdt_circle = new Circle(x, y+1, 8);
        Rectangle bdt_rectangle = new Rectangle(x+1, y, x+1, y-12, x-1, y-12, x-1, y);

        bdt_circle.Draw_Shape();
        bdt_rectangle.Draw_Shape();
    }
}
