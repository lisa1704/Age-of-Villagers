using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Nation
{
    class EgyptianKing : INation
    {
        private Color colorofbackground = Color.Yellow;
        public Color BgColor()
        {
            return colorofbackground;
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
    }
}