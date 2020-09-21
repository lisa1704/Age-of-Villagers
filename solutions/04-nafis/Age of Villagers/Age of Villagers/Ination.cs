using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers
{
    interface INation
    {
        IShape HouseDraw();
        IShape TreeDraw();
        IShape WaterSourceDraw();
    }
}
