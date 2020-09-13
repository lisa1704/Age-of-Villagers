using System;
using System.Drawing;
using System.Windows.Forms;

public class ArabBedouin : INation
{
    Pen p = new Pen(Color.Black);
    Panel panel;
    public ArabBedouin(Panel panel)
	{
        this.panel = panel;
    }

    public void drawHouse(Graphics g, int X, int Y)
    {
        g.DrawLine(p, X, Y + 50, X + 25, Y);
        g.DrawLine(p, X + 25, Y, X + 50, Y + 50);
        g.DrawLine(p, X + 50, Y + 50, X, Y + 50);
        g.DrawLine(p, X + 25, Y, X + 75, Y - 25);
        g.DrawLine(p, X + 75, Y - 25, X + 100, Y + 25);
        g.DrawLine(p, X + 100, Y + 25, X + 50, Y + 50);
    }

    public void drawTree(Graphics g, int X, int Y)
    {
        g.DrawLine(p, X + 48, Y + 50, X + 52, Y + 50);
        g.DrawLine(p, X + 52, Y + 50, X + 52, Y + 100);
        g.DrawLine(p, X + 52, Y + 100, X + 48, Y + 100);
        g.DrawLine(p, X + 48, Y + 100, X + 48, Y + 50);
        g.DrawLine(p, X + 50, Y + 50, X + 50, Y + 15);
        g.DrawLine(p, X + 50, Y + 50, X + 25, Y + 25);
        g.DrawLine(p, X + 50, Y + 50, X + 75, Y + 25);
        g.DrawLine(p, X + 50, Y + 50, X + 15, Y + 40);
        g.DrawLine(p, X + 50, Y + 50, X + 85, Y + 40);
    }

    public void drawWaterSource(Graphics g, int X, int Y)
    {
        
    }

    public void paintTerrain()
    {
        panel.BackColor = Color.Yellow;
    }
}
