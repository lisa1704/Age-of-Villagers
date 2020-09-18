using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.NationFactory
{
    class ArabNationCreator : AbstractNationCreator
    {
       private String nationName = "Arab Bedouin";

        public string GetNationName
        {
            get
            {
                return nationName;
            }

            set
            {
                if (value == "Arab Bedouin")
                    nationName = value;
            }
        }

        public override INation CreateNation()
        {
            return new ArabBedouin(nationName);
            // Factory Method Implemented
        }


    }
}
