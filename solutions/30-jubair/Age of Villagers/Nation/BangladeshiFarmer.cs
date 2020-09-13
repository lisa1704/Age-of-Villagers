using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Nation
{
    class BangladeshiFarmer : INation
    {
        string name;
        
        public BangladeshiFarmer(string name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }

        public Color getTerrainColor()
        {
            throw new NotImplementedException();
        }

        public Object getHouse(Point point)
        {
            throw new NotImplementedException();
        }

        public Object getTree(Point point)
        {
            throw new NotImplementedException();
        }

        public Object getWaterResource(Point point)
        {
            throw new NotImplementedException();
        }

        
    }
}
