﻿using System.Drawing;

namespace age_of_villagers
{
    class ArabBeduin : INation
    {
        private Color colorofbackground = Color.Orange;
        public Color BgColor()
        {
           return colorofbackground;
        }

        public void drawHouse(Graphics g, Point point)
        {
            throw new System.NotImplementedException();
        }
    }
}