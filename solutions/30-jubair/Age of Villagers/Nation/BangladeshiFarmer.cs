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
            return Color.PaleGreen;
        }

        public void GetHouse(Graphics graphics, Point _point)
        {
            BangladeshiHouse bangladeshi_house = new BangladeshiHouse(new Point(_point.X, _point.Y - 8), new Point(_point.X - 8, _point.Y), new Point(_point.X + 8, _point.Y + 8));
            bangladeshi_house.Paint(graphics);  
        }

        public void GetTree(Graphics graphics, Point _point)
        {
            BangladeshiTree bangladeshi_tree = new BangladeshiTree(new Point(_point.X, _point.Y), new Point(_point.X + 9, _point.Y + 20), new Point(_point.X + 15, _point.Y + 12), new Point(_point.X + 7, _point.Y + 8));
            bangladeshi_tree.Paint(graphics);
            
        }

        public void GetWaterResource(Graphics graphics, Point _point)
        {
            BangladeshiPond bangladeshi_pond = new BangladeshiPond(new Point(_point.X, _point.Y), new Point(_point.X - 6, _point.Y + 12), new Point(_point.X, _point.Y + 18), new Point(_point.X + 9, _point.Y + 12), new Point(_point.X + 12, _point.Y + 18), new Point(_point.X + 18, _point.Y + 6), new Point(_point.X + 15, _point.Y - 3), new Point(_point.X + 6, _point.Y + 3), new Point(_point.X + 6, _point.Y - 2));
            bangladeshi_pond.Paint(graphics);
        }


    }
}
