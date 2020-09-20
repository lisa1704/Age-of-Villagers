using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class NationFactory
    {
        private readonly Graphics g;
        private readonly Form1 form;

        public NationFactory(Graphics graphics, Form1 form)
        {
            this.g = graphics;
            this.form = form;
        }
        public INation GetNation(string myNation)
        {
            if (myNation == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers(g, form);
            }
            else if (myNation == "Egyptian Kings")
            {
                return new EgyptianKings(g, form);
            }
            else if (myNation == "Arab Bedouins")
            {
                return new ArabBedouin(g, form);
            }
            else if (myNation == "Inuit Hunters")
            {
                return new InuitHunters(g, form);
            }
            throw new Exception();
        }
    }
}
