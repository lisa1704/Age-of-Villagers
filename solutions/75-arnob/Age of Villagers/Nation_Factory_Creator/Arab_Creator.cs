using Age_of_Villagers.Nation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Nation_Factory_Creator
{
    public class Arab_Creator : AbstractNationFactoryCreator
    {
        private String nationName = "Arab Bedouin";

       

        public override INation CollectNation()
        {
            return new Arab_Bedouin(nationName);
        }
    }
}
