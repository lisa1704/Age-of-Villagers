using System;

public class ArabHouse : House
{
    public void CreateHouse(int x, int y)
    {
        Triangle t = new Triangle(x-2,y+6,x-8,y-8,x+2,y-8);
        t.Draw();
        Rectangle r = new Rectangle(x - 2, y + 6, x + 2, y - 8, x + 8, y - 6, x + 1, y + 8);
        r.Draw();
    }
}
