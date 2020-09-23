using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class Egyptian : INation
    {
        public IShapes DrawTree(Graphics gr, Point p)
        {
            EgyptianTree t = new EgyptianTree(p);

            return t;

        }
      
        public IShapes DrawHouse(Graphics g, Point p)
        {
            EgyptianHouse h = new EgyptianHouse(p);
            return h;
        }

        public IShapes DrawWaterSource(Graphics g, Point p)
        {
            EgyptianWaterSource w = new EgyptianWaterSource(p);
            return w;

        }

        public Color TerrainColor()
        {
            return Color.Yellow;
        }

    }
}
