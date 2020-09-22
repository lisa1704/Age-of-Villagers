using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class ArabBedouins : INation
    {
        Color bkgColor = Color.Green;
        public Color DrawTerrain()
        {
            return bkgColor;
        }
        public void DrawHouse(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void DrawTree(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }
    }
}
