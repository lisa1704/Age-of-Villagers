using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Nation
{
    public interface INation
    {
        String getName();
        Color getTerrainColor();
        void GetTree(Graphics graphics, Point _point);
        void GetHouse(Graphics graphics, Point _point);
        void GetWaterResource(Graphics graphics, Point _point);
    }
}
