using System;

public class ArabTree : Tree
{
	public void CreateTree(int x, int y)
    {
        Rectangle r = new Rectangle(x - 1, y, x - 1, y - 12, x + 1, y - 12, x + 1, y);
        r.Draw();
        Line l1 = new Line(x, y, x - 8, y + 4);
        l1.Draw();
        Line l2 = new Line(x, y, x - 4, y + 8);
        l2.Draw();
        Line l3 = new Line(x, y, x, y + 12);
        l3.Draw();
        Line l4 = new Line(x, y, x + 4, y + 8);
        l4.Draw();
        Line l5 = new Line(x, y, x + 8, y + 4);
        l5.Draw();
    }
}
