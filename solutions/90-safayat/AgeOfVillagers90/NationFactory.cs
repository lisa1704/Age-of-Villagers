using System;

namespace AgeOfVillagers90
{
    public class NationFactory
    {
        public INation GetNation(string NationType)
        {
            if(NationType == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers();
            }
            else if (NationType == "Arab Bedouin")
            {
                return new ArabBedouin();
            }
            else if (NationType == "Egytian Kings")
            {
                return new EgyptianKings();
            }
            else if(NationType == "Inuit HUnters")
            {
                return new InuitHunters();
            }
            else
            {
                return new NullNation();
            }
            throw new Exception();
        }

    }
}
