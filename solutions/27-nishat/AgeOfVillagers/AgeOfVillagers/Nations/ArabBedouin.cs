using System.Drawing;

namespace AgeOfVillagers
{
    public class ArabBedouin : INation
    {
        private readonly string nationname;

        public ArabBedouin(string nationname)
        {
            this.nationname = nationname;
        }

        public string GetNationName()
        {
            return nationname;
        }

        public Color GetTerrainColor()
        {
            return Color.Gold;
        }

        public VillageItem GetHouse(Point point)
        {
            return new ArabHouse(point);
        }

        public VillageItem GetTree(Point point)
        {
            return new ArabTree(point);
        }

        public VillageItem GetWaterResource(Point point)
        {
            return new NoWaterResource(point);
        }
    }
}
