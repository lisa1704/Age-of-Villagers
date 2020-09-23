using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Inuit : INation
    {
        public IShapes DrawHouse(Graphics gr, Point p)
        {
            return new InuitHouse(p);
        }
        public IShapes DrawTree(Graphics gr, Point p)
        {
            NullItemSelction nt = new NullItemSelction();
            nt.DrawShapes();
            return nt;

        }

        public IShapes DrawWaterSource(Graphics gr, Point p)
        {
            NullItemSelction niw = new NullItemSelction();
            niw.DrawShapes();
            return niw;

        }

        public Color TerrainColor()
        {
            return Color.White;
        }
    }
}
