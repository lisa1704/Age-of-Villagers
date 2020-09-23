using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Bangladeshi_Farmers
{
    public class BangladeshiFarmers : INation
    {
        public Object DrawTree(Graphics g, Point point)
        {
            BDFarmersTree bdFarmersTree = new BDFarmersTree(point);
            bdFarmersTree.Draw(g);
            return bdFarmersTree;
        }
        public Object DrawHouse(Graphics g, Point point)
        {
            BDFarmersHouse bdFarmersHouse = new BDFarmersHouse(point);
            bdFarmersHouse.Draw(g);
            return bdFarmersHouse;
        }

        public Object DrawWaterSource(Graphics g, Point point)
        {
            BDFarmersWatersource bdFarmersWaterSource = new BDFarmersWatersource(point);
            bdFarmersWaterSource.Draw(g);
            return bdFarmersWaterSource;
        }

        public Color BackgroundColor()
        {
            return Color.Green;
        }

        public Object testTreePoint(Point point)
        {
            return new BDFarmersTree(point);
        }

        public Object testHousePoint(Point point)
        {
            return new BDFarmersHouse(point);
        }

        public Object testWatersourcePoint(Point point)
        {
            return new BDFarmersWatersource(point);
        }
    }
}
