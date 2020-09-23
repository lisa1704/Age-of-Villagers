using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    interface INation
    {
        IShape HouseDraw();
        Point GetHousePoint();
        IShape TreeDraw();
        Point GetTreePoint();
        IShape WaterSourceDraw();
    }
}
