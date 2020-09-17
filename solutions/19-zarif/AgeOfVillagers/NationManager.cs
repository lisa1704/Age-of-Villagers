using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class NationManager
    {
        private string _nationtype;
        Panel _Drawpanel;
        public NationManager(string nationtype,Panel Drawpanel)
        {
            _nationtype = nationtype;
            _Drawpanel = Drawpanel;
        }

        public INation getNation()
        {
            if (_nationtype.Equals("Bangladeshi Farmers"))
            {
                _Drawpanel.BackColor = System.Drawing.Color.Red;

                return new BangladeshiFarmers();
            }
            else
            {

                return new ArabBedouin();
            }

        }
    }
}
