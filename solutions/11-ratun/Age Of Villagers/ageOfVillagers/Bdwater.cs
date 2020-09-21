using System;

public class Bdwater : Water
{
    private int xLength = 24;
    private int yLength = 16;
	public void CreateWater(int x, int y)
    {
        Line l1 = new Line(x - 12, y, x - 6, y + 6);
        l1.Draw();
        Line l2 = new Line(x - 6, y+6, x - 2, y + 7);
        l2.Draw();
        Line l3 = new Line(x - 2, y+7, x - 1, y + 3);
        l3.Draw();
        Line l4 = new Line(x - 1, y+3, x + 6, y + 8);
        l4.Draw();
        Line l5 = new Line(x +6, y+8, x + 12, y +2);
        l5.Draw();
        Line l6 = new Line(x + 12, y+2, x + 5, y - 7);
        l6.Draw();
        Line l7 = new Line(x + 5, y - 7, x - 1, y - 2);
        l7.Draw();
        Line l8 = new Line(x - 1, y - 2, x - 6, y + 8);
        l8.Draw();
        Line l9 = new Line(x - 6, y + 8, x - 12, y);
        l9.Draw();
    }
}
