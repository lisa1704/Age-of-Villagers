using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Age_of_Villagers.NationFactory
{
    public class ConcreteNationCreator1 : NationCreator
    {
       
        
            String nationName = "Bangladeshi Farmers";

            public string GetNationName
            {
                get => nationName;
                set => nationName = value;
            }

        public override INation CreateNation()
        {
            return new BangladeshiFarmer(GetNationName);
            // Factory Method Implemented
        }
    }
        
        
    }

