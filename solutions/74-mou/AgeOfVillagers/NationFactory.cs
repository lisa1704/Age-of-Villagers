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
        public INation GetNation(string checked_nation)
        {
            if (typeofnation.Equals("Bangladeshi Farmers"))
            {
                return new Bangladeshi();
            }
            else if (typeofnation.Equals("Arab Bedouin"))
            {
                return new Arab();
            }
            else if (typeofnation.Equals("Egyptian Kings"))
            {
                return new Egyptian();

            }
            else
            {
                return new Inuit();
            }
        }





    }
}
