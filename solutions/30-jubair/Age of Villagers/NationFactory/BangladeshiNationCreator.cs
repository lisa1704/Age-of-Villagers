using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Age_of_Villagers.NationFactory
{
    public class BangladeshiNationCreator : AbstractNationCreator
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
                if(value == "Bangladeshi Farmers")
                nationName = value;
            }
          }

        public override INation CreateNation()
        {
            return new BangladeshiFarmer(nationName);
            // Factory Method Implemented
        }
    }
        
        
    }

