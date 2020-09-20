using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace Age_of_villagers.Nations
{
    class BangladeshiFarmers : INation
    {
        public string DrawHouse(Graphics g, Point pt)
        {
            throw new NotImplementedException();
        }

        public string GetNation()
        {
            return "BangladeshiFarmers";
        }

        public Color GetTerrainColor()
        {
            throw new NotImplementedException();
        }

        void INation.DrawTree(Graphics g, Point pt)
        {
            throw new NotImplementedException();
        }

        void INation.DrawWaterSource(Graphics g, Point MPt)
        {
            throw new NotImplementedException();
        }
    }
}
