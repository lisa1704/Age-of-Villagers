using System;

public class InuitHouse : House
{
	public void CreateHouse(int x, int y)
    {
        HalfCircle h1 = new HalfCircle(x,y,8);
        h1.Draw();
        HalfCircle h2 = new HalfCircle(x, y, 2);
        h2.Draw();
    }
}
