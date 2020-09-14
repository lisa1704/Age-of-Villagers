using System;
using System.Drawing;
using System.Windows.Forms;

public abstract class Nation
{
    protected Graphics g;
    protected Panel panel; 
    protected Color color;
    protected ITree tree;
    protected IHouse house;
    protected IWaterSource waterSource;
    public Nation(Graphics newg , Panel panel)
    {
        g = newg;
        this.panel = panel;
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

    // ei khane COlor.color na die ekta  panel ta ki korbo bolo -.-
    public void paintTerrain()
    {
        panel.BackColor = color;
    }
}
