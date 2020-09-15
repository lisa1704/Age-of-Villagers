using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Nation
{
    class InuitHunter : INation
    {
        string name;

        public InuitHunter(string name)
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

        public void GetHouse(Graphics graphics, Point _point)
        {
            throw new NotImplementedException();
        }

        public void GetTree(Graphics graphics, Point _point)
        {
            throw new NotImplementedException();
        }

        public void GetWaterResource(Graphics graphics, Point _point)
        {
            throw new NotImplementedException();
        }


    }
}
