using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    public class NationFactory
    {
        public string typeofnation;
        public NationFactory(string typeofnation)
        {
            this.typeofnation = typeofnation;
        }
        public INation GetNation()
        {
            if (typeofnation.Equals("Bangladeshi Farmers"))
            {
                return new Bangladeshi();
            }
            else return null;

           else if (typeofnation.Equals("Arab Bedouin"))
            {
                return new Arab();
            }
        }





    }
}
