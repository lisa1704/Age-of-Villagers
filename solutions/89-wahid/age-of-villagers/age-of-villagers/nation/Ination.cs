using age_of_villagers.villageitem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace age_of_villagers.nation
{
    interface Ination
    {
        string getNationName();
        Color getTerrainColor();
        villageitem.villageitem getHouse(Point p);
        villageitem.villageitem getTree(Point p);
        villageitem.villageitem getWaterSource(Point p);

    }
}
