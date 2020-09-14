using System;
using System.Drawing;
using System.Windows.Forms;

public class EgyptianKings : Nation
{
   
    public EgyptianKings(Graphics newg , Panel panel) : base(newg , panel)
    {
        base.color = Color.Yellow;
        g = newg;
        base.house = new EgyptianKingsHouse();
        base.tree = new EgyptianKingsTree();
        base.waterSource = new EgyptianKingsWaterSource();
        paintTerrain();
    }
}
