using Age_of_Villagers.Age_of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.EgyptianKings
{
    public class EgyptianKings:INation
    {
        Graphics g;
        Pen pen = new Pen(Color.Black);
        public Color BackgroundColor()
        {
            return Color.Yellow;
        }

        public IShape DrawHouse(Graphics g, Point point)
        {
            EgyptianHouse egyptianhouse = new EgyptianHouse(point);
            return (egyptianhouse);
        }

        public IShape DrawTree(Graphics g, Point point)
        {
            EgyptianTrees egyptiantree = new EgyptianTrees(point);
            return (egyptiantree);
        }

        public IShape DrawWaterSource(Graphics g, Point point)
        {
            EgyptianWaterS egyptianWater= new EgyptianWaterS(point);
            return (egyptianWater);
        }

        public IShape testhouse(Point p)
        {
            return new EgyptianHouse(p);
        }
    }
}
