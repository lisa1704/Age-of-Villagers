using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class BanglaFarmers : INation
    {
        Pen pen = new Pen(Color.Green);
        public void DrawHouse(Graphics graphics, Point point)
        {
            throw new NotImplementedException();
        }

        public void DrawTree(Graphics graphics, Point point)
        {
            BanglaTree bdTree = new BanglaTree(point);
            bdTree.Draw(graphics, pen);
        }

        public void DrawWaterSource(Graphics graphics, Point point)
        {
            throw new NotImplementedException();
        }

        public void SetTerrain()
        {
            throw new NotImplementedException();
        }

        public void SetWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
