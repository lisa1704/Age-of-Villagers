using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillegers 
{
	public class Factory_Nation
	{
		public INation GetNation(string nation)
        {
			if(nation=="Bangladeshi Farmers")
            {
				return new Bangladehsi_farmers() ;
            }
			else if (nation=="Egyptian Kings")
            {
				return new Egyptian_kings();
            }
			else if (nation=="Inuit Hunters")
            {
				return new Inuit_hunters();
            }
			else if(nation== "Arab Bedouins")
            {
				return new Arab_bedouins();

			}
			else
            {
				return new NullNation();
            }

        }
	}
}
