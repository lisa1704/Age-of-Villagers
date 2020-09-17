using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface INation
    {
        string nationName { get; set; }
        Color getTerrainColor();
        string getNationName();
        Object getTree(Point point);
        Object getHouse(Point point);
        Object getWaterResource(Point point);
    }
}
