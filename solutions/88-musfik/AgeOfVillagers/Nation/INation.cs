using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface INation
    {
        string nationName { get; set; }
        Color getTerrainColor();
        string getNationName();
        IShape getItemShape(Point point, String itemType);
    }
}
