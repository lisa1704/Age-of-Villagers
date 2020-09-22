using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Arab : INation
    {

        public IShapes DrawHouse(Graphics gr,Point p)
        {
            return new ArabHouse(p);
        }
        public IShapes DrawTree(Graphics gr,Point p)
        {
            return new ArabTree(p);

        }

        public IShapes DrawWaterSource(Graphics gr,Point p)
        {
            return new NullItemSelction();

        }

        public Color TerrainColor()
        {
            return Color.PaleGoldenrod;
        }
    }
}
