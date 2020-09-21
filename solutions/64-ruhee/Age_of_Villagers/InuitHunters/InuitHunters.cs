using Age_of_Villagers.Age_of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.InuitHunters
{
    public class InuitHunters: INation
    {
        Graphics g;
        Pen pen = new Pen(Color.Black);
        public void DrawTree(Graphics g, Point point)
        {
            NullElements InuitHouse = new NullElements();
            InuitHouse.Draw(g,pen);
        }

        public void DrawHouse(Graphics g, Point point)
        {
            NullElements InuitWaterSource = new NullElements();
            InuitWaterSource.Draw(g, pen);
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            NullElements InuitWaterSource = new NullElements();
            InuitWaterSource.Draw(g, pen);
        }

        public Color BackgroundColor()
        {
            return Color.White;
        }

    }
}
