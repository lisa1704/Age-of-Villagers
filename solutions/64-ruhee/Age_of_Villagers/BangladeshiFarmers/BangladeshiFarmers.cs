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
        public void DrawTree(Graphics g, Point point)
        {
            BangladeshiTrees bdFarmersTree = new BangladeshiTrees(point);
            bdFarmersTree.Draw(g,pen);
        }
        public void DrawHouse(Graphics g, Point point)
        {
            BangladeshiHouse bdFarmersHouse = new BangladeshiHouse(point);
            bdFarmersHouse.Draw(g,pen);
        }

        public string BangladeshiFarmerTest()
        {
            string NationName = "Bangladesh";
            return NationName;
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            BangladeshiWaterS bdWater = new BangladeshiWaterS(point);
            bdWater.Draw(g,pen);
        }

        public Color BackgroundColor()
        {
            return Color.Green;
        }
    }
}
