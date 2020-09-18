using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.NationFactory
{
    class EgyptianNationCreator : AbstractNationCreator
    {
        private String nationName = "Egyptian Kings";

        public string GetNationName
        {
            get
            {
                return nationName;
            }

            set
            {
                if (value == "Egyptian Kings")
                    nationName = value;
            }
        }

        public override INation CreateNation()
        {
            return new EgyptianKings(nationName);
            // Factory Method Implemented
        }
    }
}
