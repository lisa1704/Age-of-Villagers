using Age_of_Villagers.Age_of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.InuitHunters
{
    public class InuitHunters: INation
    {
        public void DrawTree(Graphics g, Point point)
        {
            NullElements InuitHouse = new NullElements();
            InuitHouse.drawing();
        }

        public void DrawHouse(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            NullElements InuitWaterSource = new NullElements();
            InuitWaterSource.drawing();
        }

        public Color BackgroundColor()
        {
            return Color.White;
        }

    }
}
