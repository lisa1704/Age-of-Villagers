using Age_of_Villagers.House;
using Age_of_Villagers.Tree;
using Age_of_Villagers.Water_Resource;
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

        public void GetTree(Graphics graphics, Point _point)
        {
            BangladeshiTree bangladeshi_tree = new BangladeshiTree(new Point(_point.X, _point.Y), new Point(_point.X+9, _point.Y+30), new Point(_point.X+15, _point.Y+18), new Point(_point.X+7, _point.Y+12));
            bangladeshi_tree.Paint(graphics);
            //Point mainPoint, Point topRight, Point bottomRight, Point topPoint, Point topLeft
            
        }

        public void GetWaterResource(Graphics graphics, Point _point)
        {
            BangladeshiPond bangladeshi_pond = new BangladeshiPond(new Point(_point.X, _point.Y),new Point(_point.X - 12, _point.Y + 24), new Point(_point.X , _point.Y + 36), new Point(_point.X + 18, _point.Y + 24), new Point(_point.X + 24, _point.Y + 36),new Point(_point.X+36, _point.Y+12), new Point(_point.X+30, _point.Y-6), new Point(_point.X+12, _point.Y+12), new Point(_point.X+12, _point.Y-3));
            bangladeshi_pond.Paint(graphics);
        }


    }
}
