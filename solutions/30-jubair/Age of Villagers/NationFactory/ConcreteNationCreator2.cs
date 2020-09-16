using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.NationFactory
{
    class ConcreteNationCreator2 : NationCreator
    {
        String n_name = "Arab Bedouin";

        public string nation_name
        {
            get => n_name;
            set => n_name = value;
        }

        public override INation CreateNation()
        {
            return new ArabBedouin(nation_name);
            // Factory Method Implemented
        }


    }
}
