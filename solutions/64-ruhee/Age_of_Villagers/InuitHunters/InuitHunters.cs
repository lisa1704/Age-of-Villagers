using Age_of_Villagers.Age_of_Villagers;
using Age_of_Villagers.InuitHunters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.EgyptianKings
{
    public class InuitHunters : INation
    {
        Graphics g;
        Pen pen = new Pen(Color.Black);
        public Color BackgroundColor()
        {
            return Color.Yellow;
        }

        public void DrawHouse(Graphics g, Point point)
        {
            InuitHouse Inuithouse = new InuitHouse(point);
            Inuithouse.Draw(g, pen);
        }

        public void DrawTree(Graphics g, Point point)
        {
            NullElements InuitTree = new NullElements();
            InuitTree.drawing();
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            NullElements InuitWater = new NullElements();
            InuitWater.drawing();
        }
    }
}
