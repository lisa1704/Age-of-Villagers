using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class InuitHunters : INation
    {
        Color bkgColor = Color.Purple;
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
