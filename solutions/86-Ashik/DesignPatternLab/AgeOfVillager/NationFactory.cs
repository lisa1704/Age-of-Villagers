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

        public NationFactory(Graphics graphics)
        {
            this.g = graphics;
        }
        public INation GetNation(string myNation)
        {
            if (myNation == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers(g);
            }
            else if (myNation == "Egyptian Kings")
            {
                return new EgyptianKings();
            }
            else if (myNation == "Arab Bedouins")
            {
                return new ArabBedouin();
            }
            else if (myNation == "Inuit Hunters")
            {
                return new InuitHunters(g);
            }
            throw new Exception();
        }
    }
}
