using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class ArabBedouin : INation
    {

        Pen pen = new Pen(Color.Black);
        public string DrawHouse(Graphics g, Point p)
        {
            return "Stonehouse";
        }

        public void DrawTree(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
