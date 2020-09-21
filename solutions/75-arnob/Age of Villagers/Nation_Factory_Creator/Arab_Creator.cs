using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Arab_Creator : AbstractNationFactoryCreator
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

        public override INation CreateNation => new Arab_Bedouin(nationName);
    }
}
