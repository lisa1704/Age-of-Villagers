using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class BangladeshiFarmers : INation
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
        public void DrawWaterSource(Graphics g, Point point)
        {
            BDFarmersWatersource bdFarmersWaterSource = new BDFarmersWatersource(point);
            bdFarmersWaterSource.Draw(g);
        }
    }
}
