using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class NullNation : INations
    {
        public string DrawHouse(Graphics g, Point pt)
        {
            throw new NotImplementedException();
        }

        public void DrawTree(Graphics g, Point pt)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource(Graphics g, Point MPt)
        {
            throw new NotImplementedException();
        }

        public Color GetTerrainColor()
        {
            return Color.MintCream;
        }
    }
}
