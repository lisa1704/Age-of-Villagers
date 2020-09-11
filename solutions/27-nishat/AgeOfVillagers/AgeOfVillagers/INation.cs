using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface INation
    {
        String GetNationName();
        Color GetTerrainColor();
        VillageItem GetTree(Point point);
        VillageItem GetHouse(Point point);
        VillageItem GetWaterResource(Point point);
    }

    public interface INationFactory
    {
        string NationName { get; set; }
        INation GetNation();
    }

    public class InuitHuntersNationfactory : INationFactory
    {
        String Nationname = "Inuit Hunters";

        public string NationName { get => Nationname; set => Nationname = value; }

        public INation GetNation()
        {
            return new InuitHunters(Nationname);
        }
    }
    public class EgyptianKingsNationfactory : INationFactory
    {
        String Nationname = "Egyptian Kings";

        public string NationName { get => Nationname; set => Nationname = value; }

        public INation GetNation()
        {
            return new EgyptianKings(Nationname);
        }
    }
    public class ArabBedouinNationfactory : INationFactory
    {
        String Nationname = "Arab Bedouin";

        public string NationName { get => Nationname; set => Nationname = value; }

        public INation GetNation()
        {
            return new ArabBedouin(Nationname);
        }
    }
    public class BangladeshiNationfactory : INationFactory
    {
        String Nationname = "Bangladeshi Farmers";

        public string NationName { get => Nationname; set => Nationname = value; }

        public INation GetNation()
        {
            return new BalgladeshiFarmers(Nationname);
        }
    }
}
