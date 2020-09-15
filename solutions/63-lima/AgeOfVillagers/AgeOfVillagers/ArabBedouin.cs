using System;
using System.Drawing;
using System.Windows.Forms;

public class ArabBedouin : NationAbstract
{
    public ArabBedouin(Graphics newg , Panel panel) : base(newg , panel)
	{
        base.color = Color.LightYellow;
        g = newg;
        base.house = new ArabBedouinHouse();
        base.tree = new ArabBedouinTree();
        base.waterSource = new NullWaterSource();
        paintTerrain();

    }
}
