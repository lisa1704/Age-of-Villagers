using Age_of_Villagers.House;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Nation
{
    public class BangladeshiFarmer : INation
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

        public void GetHouse(Graphics graphics, Point _point)
        {
            BangladeshiHouse bangladeshi_house = new BangladeshiHouse(new Point(_point.X, _point.Y-16), new Point(_point.X - 16, _point.Y), new Point(_point.X + 16, _point.Y +16 ));
            bangladeshi_house.Paint(graphics);
            
            
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
