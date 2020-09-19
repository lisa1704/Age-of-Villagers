using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    public class NationComponentFactory
    {
        public static VillageComponentFactory getNation(string nationName)
        {
            if(nationName=="Bangladeshi Farmer")
            {
                return new BdFarmerComponentFactory();
            }
            else if(nationName=="Arab Bedouin")
            {
                return new ArabBedouinComponentFactory();
            }
            else if(nationName=="Egyptian King")
            {
                return new EgyptianKingComponentFactory();
            }
            else if (nationName == "Inuit Hunter")
            {
                return new InuitHunterComponentFactory();
            }
            return new NullComponentFactory();
        }
    }
}
