using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.NationFactory
{
    class EgyptianNationCreator : AbstractNationCreator
    {
        String nationName = "Egyptian Kings";

        public string GetNationName
        {
            get => nationName;
            set => nationName = value;
        }

        public override INation CreateNation()
        {
            return new EgyptianKings(nationName);
            // Factory Method Implemented
        }
    }
}
