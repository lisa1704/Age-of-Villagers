using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class Nations
    {
        public INation nation;
        public string nationtype;
        public Nations( string nationtype)
        {
            this.nationtype = nationtype;

        
        
        
            if (nationtype == "Bangladeshi Farmers")
            {
                nation = new BdFarmer();

            }
            else if (nationtype == "Arab Beduins")
            {
                nation = new ArabBeduin();
            }
            else if (nationtype == "Egyptian King")
            {
                nation = new EgyptianKing();
            }
            else if (nationtype == "Inuit Hunter")
            {
                nation = new InuitHunter();
            }
            
        }
        public INation GetNation()
        {
            return nation;
        }
    }
}
