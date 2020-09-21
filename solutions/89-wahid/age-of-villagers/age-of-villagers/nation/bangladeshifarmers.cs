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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public villageitem.villageitem getWaterSource(Point p)
        {
            throw new NotImplementedException();
        }
    }
}
