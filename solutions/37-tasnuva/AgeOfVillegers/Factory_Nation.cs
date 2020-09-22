using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillegers 
{
	public class Factory_Nation
	{
		public INation GetNation(string type)
        {
			if(type=="Bangladeshi Farmers")
            {
				return new Bangladehsi_farmers() ;
            }
			else if (type=="Egyptian Kings")
            {
				return new Egyptian_kings();
            }
			else if (type=="Inuit Hunters")
            {
				return new Inuit_hunters();
            }
			else if(type== "Arab Bedouins")
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
