using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Age_of_Villagers.Shape;

namespace Age_of_Villagers.Nation
{
    public class NullNation : INation
    {
        string nullName = "No Nation";

        public String getName()
        {
            return nullName;
        }
        public Color getTerrainColor()
        {
            return Color.Transparent;
        }
        public void GetTree(Graphics graphics, Point _point)
        {
            NullVillageComponent null_object = new NullVillageComponent(_point);
            null_object.Paint(graphics);
        }

       public void GetHouse(Graphics graphics, Point _point)
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
