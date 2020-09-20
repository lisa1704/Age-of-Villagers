using Age_of_Villagers.House;
using Age_of_Villagers.Shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers.Nation
{
    public class InuitHunter : INation
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
            return Color.White;
        }

        public void GetHouse(Graphics graphics, Point _point)
        {
            InuitHouse inuit_house = new InuitHouse(new Point(_point.X, _point.Y), new Point(_point.X+16, _point.Y ) );
            inuit_house.Paint(graphics);
            
        }

        public void GetTree(Graphics graphics, Point _point)
        {
            NullVillageComponent null_object = new NullVillageComponent(_point);
            null_object.Paint(graphics);
        }

        public void GetWaterResource(Graphics graphics, Point _point)
        {
            NullVillageComponent null_object = new NullVillageComponent(_point);
            null_object.Paint(graphics);
        }


    }
}
