using System.Drawing;

namespace AgeOfVillagers
{
    public class BalgladeshiFarmers : INation
    {
        private readonly string nationname;

        public BalgladeshiFarmers(string nationname)
        {
            this.nationname = nationname;
        }

        public string GetNationName()
        {
            return nationname;
        }

        public Color GetTerrainColor()
        {
            return Color.Green;
        }

        public VillageItem GetHouse(Point point)
        {
            return new BangladeshiHouse(point);
        }

        public VillageItem GetTree(Point point)
        {
            return new BangladeshiTree(point);
        }

        public VillageItem GetWaterResource(Point point)
        {
            return new SampleWaterResource(point);
        }
    }
}
