using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EgyptianKings : INation
    {
        Color bkgColor = Color.LightYellow;
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
