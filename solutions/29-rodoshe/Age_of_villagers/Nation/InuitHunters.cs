using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Nation
{
    class InuitHunters : INation
    {
        private Color Colorbackground = Color.White;
        public Color BgColor()
        {
            return Colorbackground;
        }
        public void DrawHouse()
        {
            throw new NotImplementedException();
        }

        public void DrawTree()
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource()
        {
            throw new NotImplementedException();
        }

        public VillageComponents.VillageComponents getHouse(Point p)
        {
            throw new NotImplementedException();
        }

        public string getNationName()
        {
            throw new NotImplementedException();
        }

        public VillageComponents.VillageComponents getTree(Point p)
        {
            throw new NotImplementedException();
        }

        public VillageComponents.VillageComponents getWaterSource(Point p)
        {
            throw new NotImplementedException();
        }
    }

}