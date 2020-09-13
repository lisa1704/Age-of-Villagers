using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Age_of_Villagers.NationFactory
{
    class ConcreteNationCreator1 : NationCreator
    {
       
        
            String n_name = "Bangladeshi";

            public string nation_name
            {
                get => n_name;
                set => n_name = value;
            }

        public override INation createNation()
        {
            return new BangladeshiFarmer(nation_name);
            // Factory Method Implemented
        }
    }
        
        
    }

