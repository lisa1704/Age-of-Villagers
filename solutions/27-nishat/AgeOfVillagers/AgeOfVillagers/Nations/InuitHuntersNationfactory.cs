using System;

namespace AgeOfVillagers
{
    public class InuitHuntersNationfactory : INationFactory
    {
        String Nationname = "Inuit Hunters";

        public string NationName { get => Nationname; set => Nationname = value; }

        public INation GetNation()
        {
            return new InuitHunters(Nationname);
        }
    }
}
