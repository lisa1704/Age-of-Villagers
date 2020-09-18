using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.NationFactory
{
    class InuitNationCreator : AbstractNationCreator
    {
        private String nationName = "Inuit Hunters";

        public string GetNationName
        {
            get
            {
                return nationName;
            }

            set
            {
                if (value == "Inuit Hunters")
                    nationName = value;
            }
        }

        public override INation CreateNation()
        {
            return new InuitHunter(nationName);
            // Factory Method Implemented
        }

    }
}
