using Age_of_Villagers.House;
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
            InuitHouse inuit_house = new InuitHouse(new Point(_point.X, _point.Y), new Point(_point.X+16, _point.Y ) );
            inuit_house.Paint(graphics);
            
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
