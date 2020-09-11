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
            return new SampleHouse(point);
        }

        public VillageItem GetTree(Point point)
        {
            return new Sampletree(point);
        }

        public VillageItem GetWaterResource(Point point)
        {
            return new SampleWaterResource(point);
        }
    }
}
