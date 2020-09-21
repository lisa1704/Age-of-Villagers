using System;

public class Bdhouse : House
{
	public void CreateHouse(int x, int y)
    {
        new Triangle(x - 12, y, x, y + 8, x + 12, y);
        t.Draw();
        new Rectangle(x - 12, y, x + 12, y, x + 12, y - 12, x - 12, y - 12);
        r.Draw();
    }
}
