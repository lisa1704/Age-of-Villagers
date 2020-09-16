using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.NationFactory
{
    class InuitNationCreator : AbstractNationCreator
    {
        String nationName = "Inuit Hunter";

        public string GetNationName
        {
            get => nationName;
            set => nationName = value;
        }

        public override INation CreateNation()
        {
            return new InuitHunter(nationName);
            // Factory Method Implemented
        }

    }
}
