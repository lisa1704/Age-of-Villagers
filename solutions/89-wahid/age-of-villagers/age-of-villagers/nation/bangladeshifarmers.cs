using age_of_villagers.villageitem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace age_of_villagers.nation
{
    class bangladeshifarmers : Ination
    {
        private Color colorofbackground = Color.Green;

        public villageitem.villageitem getHouse(Point p)
        {
            return new bangladeshihouse(p);
        }

        public string getNationName()
        {
            return "bangladeshi farmers";
        }

        public Color getTerrainColor()
        {
            return colorofbackground;
        }

        public villageitem.villageitem getTree(Point p)
        {
            return new bangladeshitree(p);
        }

        public villageitem.villageitem getWaterSource(Point p)
        {
            return new bangladeshiwatersource(p);
        }
    }
}
