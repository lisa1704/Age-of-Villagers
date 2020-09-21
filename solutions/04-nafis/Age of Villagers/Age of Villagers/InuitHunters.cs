using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers
{
    class InuitHunters : INation
    {
        IShape INation.HouseDraw()
        {
            throw new NotImplementedException();
        }

        IShape INation.TreeDraw()
        {
            throw new NotImplementedException();
        }

        IShape INation.WaterSourceDraw()
        {
            throw new NotImplementedException();
        }
    }
}
