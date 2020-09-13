using System;

namespace AgeOfVillagers
{
    public class EgyptianKingsNationfactory : INationFactory
    {
        String Nationname = "Egyptian Kings";

        public string NationName { get => Nationname; set => Nationname = value; }

        public INation GetNation()
        {
            return new EgyptianKings(Nationname);
        }
    }
}
