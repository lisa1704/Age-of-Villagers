using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Nation
{
    interface INation
    {
        string getNationName();
        Color getTerrainColor();
    }
    public class BangladeshiFarmers : INation
    {
        public string getNationName()
        {
            throw new NotImplementedException();
        }

        public Color getTerrainColor()
        {
            throw new NotImplementedException();
        }
    }
}
