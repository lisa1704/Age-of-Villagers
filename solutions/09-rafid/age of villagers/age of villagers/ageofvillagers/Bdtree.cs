using System;

public class Bdtree : Tree
{
	public void CreateTree(int x, int y)
    {
        Circle bdtCircle = new Circle(x, y + 1, 8);
        bdtCirlce.Draw_Shape();

        Rectangle bdtRectangle = new Rectangle(x + 1, y, x + 1, y - 12, x - 1, y - 12, x - 1, y);
        bdtRectangle.Draw_Shape();
    }
}
