using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers.Age_of_Villagers;

namespace Age_of_Villagers.ArabBedouin
{
    public class ArabBedouin : INation
    {
        Graphics g;
        Pen pen = new Pen(Color.Black);
        public Color BackgroundColor()
        {
            return Color.GreenYellow;
        }

        public IShape DrawHouse(Graphics g, Point point)
        {
            ArabHouse arabHouse = new ArabHouse(point);
            return (arabHouse);
        }

        public IShape DrawTree(Graphics g, Point point)
        {
            ArabTrees arabTree = new ArabTrees(point);
            return (arabTree);
        }

        public IShape DrawWaterSource(Graphics g, Point point)
        {
            NullElements arabWaterS = new NullElements();
            return (arabWaterS);
        }

        public IShape testhouse(Point p)
        {
            return new ArabHouse(p);
        }

        public IShape testtree(Point p)
        {
            return new ArabTrees(p);
        }

        public IShape testwater(Point p)
        {
            return new NullElements();
        }
    }
}
