using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface INation
    {
        String GetNationName();
        Color GetTerrainColor();
    }

    public interface INationFactory
    {
        string NationName { get; set; }
        INation GetNation();
    }
    public class Nation1 : INation
    {
        string nationname;

        public Nation1(string nationname)
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
    }

    public class Nation2 : INation
    {
        string nationname;

        public Nation2(string nationname)
        {
            this.nationname = nationname;
        }
        public string GetNationName()
        {
            return nationname;
        }
        public Color GetTerrainColor()
        {
            return Color.Blue;
        }

    }
    public class Nation3 : INation
    {
        string nationname;

        public Nation3(string nationname)
        {
            this.nationname = nationname;
        }
        public string GetNationName()
        {
            return nationname;
        }
        public Color GetTerrainColor()
        {
            return Color.Red;
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
    public class Nationfactory2 : INationFactory
    {
        String Nationname = "nation 2 ";

        public string NationName { get => Nationname; set => Nationname = value; }

        public INation GetNation()
        {
            return new Nation2(Nationname);
        }
    }
    public class Nationfactory1 : INationFactory
    {
        String Nationname = "nation 1 ";

        public string NationName { get => Nationname; set => Nationname = value; }

        public INation GetNation()
        {
            return new Nation1(Nationname);
        }
    }
}
