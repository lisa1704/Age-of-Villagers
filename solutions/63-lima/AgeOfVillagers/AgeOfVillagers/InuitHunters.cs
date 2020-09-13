using System;
using System.Drawing;
using System.Windows.Forms;

public class InuitHunters : INation
{
    Pen p = new Pen(Color.Black);
    Panel panel;
    public InuitHunters(Panel panel)
    {
        this.panel = panel;
    }
    public void drawTree(Graphics g, int X, int Y)
    {
        throw new NotImplementedException();
    }

    public void drawHouse(Graphics g, int X, int Y)
    {
        throw new NotImplementedException();
    }

    public void drawWaterSource(Graphics g, int X, int Y)
    {
        throw new NotImplementedException();
    }

    public void paintTerrain()
    {
        panel.BackColor = Color.White;
    }
}
