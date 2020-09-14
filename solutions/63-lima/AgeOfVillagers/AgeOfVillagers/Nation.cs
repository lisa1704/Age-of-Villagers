using System;
using System.Drawing;

public abstract class Nation
{
    protected Graphics g;

    ITree tree;
    IHouse house;
    IWaterSource waterSource;
    public Nation(Graphics newg)
    {
        g = newg;
    }
	public void drawTree(int X, int Y)
    {
        tree.drawTree(g, X, Y);
    }
    public void drawHouse(int X , int Y)
    {
        house.drawHouse(g, X, Y);

    }

    public void drawWaterSource(int X , int Y)
    {
        waterSource.drawWaterSource(g, X, Y);

    }
}
