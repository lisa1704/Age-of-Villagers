using System;

public class Bdhouse : House
{
	public void CreateHouse(int x, int y)
    {
        Triangle t = new Triangle(x, y + 12, x - 12, y, x + 12, y);
        t.Draw();
        Rectangle r = new Rectangle(x - 12, y, x + 12, y, x + 12, y - 12, x - 12, y - 12);
        r.Draw();
    }
}
