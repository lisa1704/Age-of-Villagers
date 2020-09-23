using Age_of_Villagers.Age_of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.BangladeshiFarmers
{
    public class BangladeshiFarmers : INation
    {
        Graphics g;
        Pen pen = new Pen(Color.Black);
        public IShape DrawTree(Graphics g, Point point)
        {
            BangladeshiTrees bdTree = new BangladeshiTrees(point);
            return (bdTree);
        }
        public IShape DrawHouse(Graphics g, Point point)
        {
            BangladeshiHouse bdHouse = new BangladeshiHouse(point);
            bdHouse.Draw(g,pen);
            return (bdHouse);
        }


        public IShape DrawWaterSource(Graphics g, Point point)
        {
            BangladeshiWaterS bdWater = new BangladeshiWaterS(point);
            bdWater.Draw(g,pen);
            return (bdWater);
        }

        public Color BackgroundColor()
        {
            return Color.Green;
        }
    }
}
