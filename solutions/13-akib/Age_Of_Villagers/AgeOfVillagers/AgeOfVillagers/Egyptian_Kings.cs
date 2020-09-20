using System;

namespace AgeOfVillagers

public class Egyptian_Kings : Nation
{
    private int x_water = 12, y_water = 12;

    public I_Shape Draw_Tree(int x, int y)
    {
        tree = new Egyptian_Tree(x, y);
        return tree;
    }
    public I_Shape Draw_House(int x, int y)
    {
        house = new Egyptian_House(x, y);
        return house;
    }
    public I_Shape Draw_WaterRes(int x_water, int y_water)
    {
        water_res = new Egyptian_WaterRes(x_water, y_water);
        return water_res;
    }

    public string BG_Color()
    {
        return "Plain Yellow color";
    }
}
