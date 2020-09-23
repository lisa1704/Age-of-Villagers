using age_of_villagers.villageitem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace age_of_villagers.nation
{
    class arabbedouin : Ination
    {
        public villageitem.villageitem getHouse(Point p)
        {
            return new bangladeshihouse();
        }

        public string getNationName()
        {
            return "Bangladeshi Farmers";
        }

        public Color getTerrainColor()
        {
            throw new NotImplementedException();
        }

        public villageitem.villageitem getTree(Point p)
        {
            throw new NotImplementedException();
        }

        public villageitem.villageitem getWaterSource(Point p)
        {
            throw new NotImplementedException();
        }
    }
}
