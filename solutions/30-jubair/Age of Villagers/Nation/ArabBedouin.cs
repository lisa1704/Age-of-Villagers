using Age_of_Villagers.House;
using Age_of_Villagers.Shape;
using Age_of_Villagers.Tree;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Nation
{
    public class ArabBedouin : INation
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
            return Color.LightYellow;
        }

        public void GetHouse(Graphics graphics, Point _point)
        {
            ArabHouse arab_house = new ArabHouse(new Point(_point.X, _point.Y), new Point(_point.X - 4, _point.Y + 13), new Point(_point.X + 4, _point.Y + 13), new Point(_point.X + 8, _point.Y - 3), new Point(_point.X + 12, _point.Y + 11));
            arab_house.Paint(graphics);
            //Point baseLeft , Point baseMedium , Point topOne, Point baseRight , Point topTwo
            
        }

        public void GetTree(Graphics graphics, Point _point)
        {
            ArabTree arab_tree = new ArabTree(new Point(_point.X, _point.Y), new Point(_point.X + 8, _point.Y - 4), new Point(_point.X - 8, _point.Y - 4), new Point(_point.X + 6, _point.Y - 10), new Point(_point.X - 6, _point.Y - 10), new Point(_point.X, _point.Y - 13), new Point(_point.X - 1, _point.Y + 8), new Point(_point.X + 1, _point.Y));
            arab_tree.Paint(graphics);        
        }

        public void GetWaterResource(Graphics graphics, Point _point)
        {
            NullVillageComponent null_object = new NullVillageComponent(_point);
            null_object.Paint(graphics);
        }

    }
}
