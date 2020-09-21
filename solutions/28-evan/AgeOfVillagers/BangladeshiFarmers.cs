using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BangladeshiFarmers : INation
    {
        Color bkgColor = Color.Red;
        public Color DrawTerrain()
        {
            return bkgColor;
        }

        public void DrawTree()
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource()
        {
            throw new NotImplementedException();
        }

        public void DrawHouse()
        {
            throw new NotImplementedException();
        }
    }
}
