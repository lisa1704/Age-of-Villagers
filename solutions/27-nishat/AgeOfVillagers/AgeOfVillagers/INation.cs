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
    public class Nation3 : INation
    {
        string nationname;

        public Nation3(string nationname)
        {
            this.nationname = nationname;
        }

        public VillageItem GetHouse(Point point)
        {
            return new SampleHouse(point);
        }

        public string GetNationName()
        {
            return nationname;
        }
        public Color GetTerrainColor()
        {
            return Color.LightYellow;
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
    public class Nationfactory3 : INationFactory
    {
        String Nationname = "nation 3 ";

        public string NationName { get => Nationname; set => Nationname = value; }

        public INation GetNation()
        {
            return new Nation3(Nationname);
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
