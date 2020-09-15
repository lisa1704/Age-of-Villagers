using Age_of_Villagers.House;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Nation
{
    class EgyptianKings : INation
    {

        string name;

        public EgyptianKings(string name)
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

            EgyptianHouse egyptian_house = new EgyptianHouse(new Point(_point.X-8, _point.Y+40), new Point(_point.X - 20, _point.Y+30), new Point(_point.X-2  , _point.Y-10 ), new Point(_point.X + 8, _point.Y+24));
            egyptian_house.Paint(graphics);
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

