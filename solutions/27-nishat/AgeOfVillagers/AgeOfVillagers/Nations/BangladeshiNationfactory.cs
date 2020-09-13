using System;

namespace AgeOfVillagers
{
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
