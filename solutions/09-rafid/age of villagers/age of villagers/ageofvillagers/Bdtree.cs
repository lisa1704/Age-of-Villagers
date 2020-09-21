using System;

public class Bdtree : Tree
{
	public void CreateTree(int x, int y)
    {
        new Circle(x, y+2, 8);
        c.Draw();
        new Rectangle(x-1, y, x+1, y, x+1, y-12, x-1, y-12);
        r.Draw();
    }
}
