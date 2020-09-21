using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Nations
{
    class Nation_factory
    {
        public INations Check_nation(string nation_name)
        {
            if (nation_name == "Bangladeshi Farmers")
            {
                return new Bangladeshi_farmers();
            }
            else if (nation_name == "Arab Bedouins")
            {
                return new Arab_bedouin();
            }
            else if(nation_name == "Egyptian Kings")
            {
                return new Egyptian_kings();
            }
            else
            {
                return new Inuit_hunters();
            }
        }
    }
}
