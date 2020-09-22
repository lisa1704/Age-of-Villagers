using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
    class village
    {
        {
        public nationcreate: village;
        public village() { }
        public nationcreate GetVillage(string villageType)
        {
            if (villageType == "Bangladeshi Farmers")
                return new Bangladeshifarmers();
            else if (villageType == "Arab Bedouin")
                return new Arabbedouin();
            else if (villageType == "Egyptian Kings")
                return new Egyptianking();
            else if (villageType == "Inuit Hunters")
                return new Inunit();
            else
                return new NullValuesHandler() ;
        }
    }
}
}
