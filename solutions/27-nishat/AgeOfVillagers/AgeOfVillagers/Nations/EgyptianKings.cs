using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianKings : INation
    {
        string nationname;

        public EgyptianKings(string nationname)
        {
            this.nationname = nationname;
        }

        public string GetNationName()
        {
            return nationname;
        }
        public Color GetTerrainColor()
        {
            return Color.Yellow;
        }

        public VillageItem GetHouse(Point point)
        {
            return new EgyptianHouse(point);
        }

        public VillageItem GetTree(Point point)
        {
            return new EgyptianTree(point);
        }

        public VillageItem GetWaterResource(Point point)
        {
            return new EgyptianWell(point);
        }
    }
}
