using System;

public class Bdtree : Tree
{
    private string drawing = "";

    private string draw(int x, int y)
    {
        Circle c = new Cicrcle(x, y + 2, 8);
        drawing += c.Draw();
        Rectangle r = new Rectangle(x - 1, y, x + 1, y, x + 1, y - 12, x - 1,y - 12);
        drawing += r.Draw();
        return drawing;

    }
	
}
