using System;

public class EgyptHouse : House
{
	public void CreateHouse(int x, int y)
    {
        Triangle t1 = new Triangle(x,y+8,x-8,y-4,x+2,y-8);
        t1.Draw();
        Triangle t2 = new Triangle(x,y+8,x+8,y,x+2,y-8);
        t2.Draw();
    }
}
