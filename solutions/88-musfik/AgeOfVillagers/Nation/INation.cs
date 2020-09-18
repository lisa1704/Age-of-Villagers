using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface INation
    {
        string nationName { get; set; }
        Color getTerrainColor();
        string getNationName();
        Tree getTree(Point point);
        House getHouse(Point point);
        WaterResource getWaterResource(Point point);
    }
}
