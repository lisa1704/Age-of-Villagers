using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class NationManager
    {
        private string _nationtype;
        private readonly Point point;

        public NationManager(string nationtype)
        {
            _nationtype = nationtype;
            
        }

        public INation getNation(Point point)
        {
            if (_nationtype.Equals("Bangladeshi Farmers"))
            {
               
                return new BangladeshiFarmers(point);
            }
            else if (_nationtype.Equals("Arab Bedouin"))
            {

                return new ArabBedouin(point);
            }

            else if (_nationtype.Equals("Egyptian Kings"))
            {
                return new EgyptianKings(point);

            }

            else if (_nationtype.Equals("Inuit Hunters"))
            {
                return new InuitHunters(point);
            }
            else
            {
                return new NullHandlingNation(point);
            }

        }
    }

    
}
