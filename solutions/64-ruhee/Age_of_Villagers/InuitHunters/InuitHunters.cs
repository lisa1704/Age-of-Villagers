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

        public IShape DrawHouse(Graphics g, Point point)
        {
            InuitHouse Inuithouse = new InuitHouse(point);
            return (Inuithouse);
        }

        public IShape DrawTree(Graphics g, Point point)
        {
            NullElements InuitTree = new NullElements();
            return (InuitTree);
        }

        public IShape DrawWaterSource(Graphics g, Point point)
        {
            NullElements InuitWater = new NullElements();
            return (InuitWater);
        }
    }
}
