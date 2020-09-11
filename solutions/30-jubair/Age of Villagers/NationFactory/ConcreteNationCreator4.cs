using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.NationFactory
{
    class ConcreteNationCreator4 : NationCreator
    {
        String n_name = "Inuit Hunter";

        public string nation_name
        {
            get => n_name;
            set => n_name = value;
        }

        public override INation createNation()
        {
            return new InuitHunter(nation_name);
            // Factory Method Implemented
        }

    }
}
