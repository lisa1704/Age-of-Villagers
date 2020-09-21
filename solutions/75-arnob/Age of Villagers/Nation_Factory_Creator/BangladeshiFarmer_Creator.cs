using System;
using Age_of_Villagers.Nation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Nation_Factory_Creator
{
    public class BangladeshiFarmer_Creator : AbstractNationFactoryCreator
    {
        private String nationName = "Bangladeshi Farmers";

        public string GetNationName
        {
            get
            {
                return nationName;
            }

            set
            {
                if (value == "Bangladeshi Farmers")
                    nationName = value;
            }
        }

        public override INation CreateNation()
        {
            return new Bangladeshi_Farmer(nationName);
        }
           
    }
}
