using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class NationManager
    {
        private string _nationtype;
      
        public NationManager(string nationtype)
        {
            _nationtype = nationtype;
           
        }

        public INation getNation()
        {
            if (_nationtype.Equals("Bangladeshi Farmers"))
            {
               
                return new BangladeshiFarmers();
            }
            else if (_nationtype.Equals("Arab Bedouin"))
            {

                return new ArabBedouin();
            }

            else if (_nationtype.Equals("Egyptian Kings"))
            {
                return new EgyptianKings();

            }

            else if (_nationtype.Equals("Inuit Hunters"))
            {
                return new InuitHunters();
            }
            else
            {
                return new NullHandlingNation();
            }

        }
    }

    
}
