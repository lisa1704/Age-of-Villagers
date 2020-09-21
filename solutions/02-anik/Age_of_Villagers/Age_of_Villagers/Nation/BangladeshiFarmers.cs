using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers.VillageComponents

 namespace Age_of_Villagers.Nation
{
    class BangladeshiFarmers : INation
    {
        private Color colorofbackground = Color.Green;
        public Color BgColor()
        {
            return colorofbackground;
        }
        public void DrawHouse()
        {
            throw new NotImplementedException();
        }

        public void DrawTree()
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource()
        {
            throw new NotImplementedException();
        }

        public VillageComponents GetHouse(Point point)
        {
            return new BangladeshiHouse(point);
        }

        public VillageComponets getTree(Point point)
        {
            return new BangladeshiTree(point);
        }

        public VillageComponents getWaterSource(Point point)
        {
            return new BangladeshiWaterSource(point);
        }
    }
}
