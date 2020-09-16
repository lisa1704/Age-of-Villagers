using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.NationFactory
{
    class ConcreteNationCreator3 : NationCreator
    {
        String n_name = "Egyptian Kings";

        public string nation_name
        {
            get => n_name;
            set => n_name = value;
        }

        public override INation CreateNation()
        {
            return new EgyptianKings(nation_name);
            // Factory Method Implemented
        }
    }
}
