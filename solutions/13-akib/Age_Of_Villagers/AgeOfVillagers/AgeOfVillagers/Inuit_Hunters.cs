using System;

namespace AgeOfVillagers

public class Inuit_Hunters : Nation
{
    public I_Shape Draw_Tree()
    {
        return NotSupportedException;
    }
    public I_Shape Draw_House(int x, int y)
    {
        house = new InuitHunters_House(x, y);
        return house;
    }
    public I_Shape Draw_WaterRes()
    {
        return NotSupportedException;
    }

    public string BG_Color()
    {
        return "Pure White";
    }
}
