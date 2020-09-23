using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    public interface INation
    {
        IShape HouseDraw();
        Point GetHousePoint();
        IShape TreeDraw();
        Point GetTreePoint();
        IShape WaterSourceDraw();
        Point GetWaterSourcePoint();
        Color GetTerrainColor();
    }
}
