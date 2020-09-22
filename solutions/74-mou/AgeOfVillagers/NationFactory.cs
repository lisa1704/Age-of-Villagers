using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class NationFactory
    {


        public INation GetNation(string typeofnation)
        {
            if (typeofnation == "Bangladeshi Farmers")
            {
                return new Bangladeshi();
            }
            else if (typeofnation == "Arab Bedouin")
            {
                return new Arab();
            }
            /*else if (typeofnation.Equals("Egyptian Kings"))
            {
                return new Egyptian();

            }*/
            else
            {
                return null;
            }
        }





    }
}
