using System;

namespace AgeOfVillagers
{
    public class ArabBedouinNationfactory : INationFactory
    {
        String Nationname = "Arab Bedouin";

        public string NationName { get => Nationname; set => Nationname = value; }

        public INation GetNation()
        {
            return new ArabBedouin(Nationname);
        }
    }
}
