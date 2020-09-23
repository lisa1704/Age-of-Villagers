using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Nations
{
    class CheckNation
    {
     
        String name;
        
        public Nation GetNation(String nationName)
        {
           name = nationName;
            if (name == "Bangladeshi Farmers")
                return new BangladeshiFarmers();
            else
                return new Nation();

        }
    }
}
