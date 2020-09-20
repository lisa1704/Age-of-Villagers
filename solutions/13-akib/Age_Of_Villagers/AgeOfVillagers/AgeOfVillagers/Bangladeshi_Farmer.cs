using System;

namespace AgeOfVillagers

public class Bangladeshi_Farmer : Nation
{
    private int x_water = 24, y_water = 16;

	public I_Shape Draw_Tree(int x, int y)
    {
        tree = new Bangladeshi_Tree(x, y);
        return tree;
    }
    public I_Shape Draw_House(int x, int y)
    {
        house = new Bangladeshi_House(x, y);
        return house;
    }
    public I_Shape Draw_WaterRes(int x_water, int y_water)
    {
        water_res = new Bangladeshi_WaterRes(x_water, y_water);
        return water_res;
    }

    public string BG_Color()
    {
        return "Plain Green color";
    }

}
