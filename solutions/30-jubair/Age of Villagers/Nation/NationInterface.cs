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
        Object getTree(Point point);
        void GetHouse(Graphics graphics,Point _point);
        Object getWaterResource(Point point);
    }
}
