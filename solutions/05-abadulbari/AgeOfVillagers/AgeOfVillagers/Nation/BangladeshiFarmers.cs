using AgeOfVillagers.Shapes;
using AgeOfVillagers.VillegeItems;
using System.Drawing;

namespace AgeOfVillagers.Nation
{
    public class BangladeshiFarmers : INation
    {
        public string getNationName()
        {
            return "Bangladeshi Farmers";
        }

        public Color getTerrainColor()
        {
            return Color.Green;
        }
        public VillageItem getHouse(Point point)
        {
            return new BangladeshiHouse(point);
        }

        public VillageItem getTree(Point point)
        {
            return new BangladeshiTree(point);
        }

        public VillageItem getWaterSource(Point point)
        {
            return new BangladeshiWaterSource(point);
        }
    }
}
