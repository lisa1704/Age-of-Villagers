using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
   public interface INation
    {
        IGraphicShape GetHouse(Point point);
        IGraphicShape GetTrees(Point point);
        IGraphicShape GetWaterSources(Point point);
    }
}
