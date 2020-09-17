using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    public class NationFactory
    {
        public INation getNation(string nation)
        {
            if(nation=="Bangladeshi Farmer")
            {
                return new BdFarmerNation();
            }
            else if(nation=="Egyptian King")
            {
                return new EgyptianKingNation();
            }
            else if(nation=="Arab Bedouin")
            {
                return new ArabBedouinNation();
            }
            else if(nation=="Inuit Hunter")
            {
                return new InuitHunterNation();
            }
            return null;
        }
    }
}
