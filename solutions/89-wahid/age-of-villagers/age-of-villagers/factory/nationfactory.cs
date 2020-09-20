using age_of_villagers.nation;
using System;
using System.Collections.Generic;
using System.Text;

namespace age_of_villagers.factory
{
    class nationfactory
    {
        string name;
        public nation.Ination Getnation(string nationtype)
        {
            if (nationtype == "bangladeshi farmers")
            {
                return new bangladeshifarmers();
            }
            else if (nationtype == "arab bedouin")
            {
                return new arabbedouin();
            }
            else if (nationtype == "egytian kings")
            {
                return new egyptiankings();
            }
            else if (nationtype == "inuit hunters")
            {
                return new inuithunters();
            }
            throw new Exception();

        }
    }
}
