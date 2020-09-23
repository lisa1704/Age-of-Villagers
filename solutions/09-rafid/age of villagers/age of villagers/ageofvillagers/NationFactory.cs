using System;
namespace age_of_villagers
{ 
    internal class NationFactory
    {
        public static Shape GetNation(string NationName)
        {
            if (Nation_Name == "Bangladeshi_Farmer")
                return new BdFactory();

            else if (Nation_Name == "Arab_Bedouin")
                return new ArFactory();
            
            else if (Nation_Name == "Egyptian_Kings")            
                return new EgFactory();
            

            return null;
        }
    }
}
