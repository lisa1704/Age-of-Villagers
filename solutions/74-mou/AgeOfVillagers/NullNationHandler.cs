using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class NullNationHandler : INation
    {
        public IShapes DrawTree(Graphics gr, Point p)
        {
            NullItemSelction nt = new NullItemSelction();
            nt.DrawShapes();
            return nt;
        }
        public IShapes DrawHouse(Graphics g, Point p)
        {
            NullItemSelction nh = new NullItemSelction();
            nh.DrawShapes();
            return nh;
        }

        public IShapes DrawWaterSource(Graphics g, Point p)
        {
            NullItemSelction nw = new NullItemSelction();
            nw.DrawShapes();
            return nw;


        }

        public Color TerrainColor()
        {
            return Color.White;
        }
    }
}
