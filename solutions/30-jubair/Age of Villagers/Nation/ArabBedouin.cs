using Age_of_Villagers.House;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Nation
{
    class ArabBedouin : INation
    {

        string name;

        public ArabBedouin(string name)
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
            ArabHouse arab_house = new ArabHouse(new Point(_point.X - 8, _point.Y - 16), new Point(_point.X - 16, _point.Y ), new Point(_point.X , _point.Y), new Point(_point.X - 24, _point.Y - 16), new Point(_point.X-32, _point.Y));
            arab_house.Paint(graphics);
            //Point baseLeft , Point baseMedium , Point topOne, Point baseRight , Point topTwo
            //new Point(_point.X - 4, _point.Y - 8), new Point(_point.X - 8, _point.Y ), new Point(_point.X , _point.Y), new Point(_point.X - 12, _point.Y - 8), new Point(_point.X-16, _point.Y)
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
