using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Bangladeshi_Farmers
{
    public class BangladeshiFarmers : INation
    {
        Pen p = new Pen(Color.Green);
        public void DrawTree(Graphics g, Point point)
        {
            BDFarmersTree bdFarmersTree = new BDFarmersTree(point);
            bdFarmersTree.Draw(g);
        }
        public void DrawHouse(Graphics g, Point point)
        {
            BDFarmersHouse bdFarmersHouse = new BDFarmersHouse(point);
            bdFarmersHouse.Draw(g);
        }

        public string BangladeshiFarmerTest()
        {
            string NationName = "Bangladesh";
            return NationName;
        }

        public void DrawWaterSource(Graphics g, Point point)
        {
            BDFarmersWatersource bdFarmersWaterSource = new BDFarmersWatersource(point);
            bdFarmersWaterSource.Draw(g);
        }

        public Color BackgroundColor()
        {
            return Color.Green;
        }
    }
}
