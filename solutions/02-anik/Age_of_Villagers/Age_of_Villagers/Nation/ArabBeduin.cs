using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Nation
{
    class ArabBeduin:INation 
    {
        private Color colorofbackground = Color.Yellow;
        public Color BgColor()
        {
            return colorofbackground;
        }
    }
}
