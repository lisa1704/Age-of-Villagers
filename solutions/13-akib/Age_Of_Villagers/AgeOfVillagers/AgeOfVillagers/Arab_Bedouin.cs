using System;

namespace AgeOfVillagers

public class Arab_Bedouin : Nation
{
    public I_Shape Draw_Tree(int x, int y)
    {
        tree = new Arab_Tree(x, y);
        return tree;
    }
    public I_Shape Draw_House(int x, int y)
    {
        house = new Arab_House(x, y);
        return house;
    }
    public I_Shape Draw_WaterRes(int x_water, int y_water)
    {
        return NotSupportedException;
    }

    public string BG_Color()
    {
        return "Yellowish";
    }
}
