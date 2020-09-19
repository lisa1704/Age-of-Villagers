using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class VillageState
    {
        string villagename;
        public VillageState(string villagename)
        {
            this.villagename = villagename;
        }
        void setState() 
        {
        }
        string getState() 
        {
            return villagename;
        }
    }
}
