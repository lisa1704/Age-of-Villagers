using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeofVillagers
{
    class NationFactory
    {
        string nation;
        Graphics g;
        public NationFactory(string nation,Graphics g)
        {
            this.nation = nation;
            this.g = g;
        }
        public Object createNation()
        {
            if (nation == "Bangladeshi Farmers")
                return new BangladeshiFarmers(g);
            else if (nation == "Arab Bedouin")
                return new ArabBeduoin(g);
            else if (nation == "Egyptian King")
                return new EgyptianKing(g);
            else if (nation == "Inuit Hunters")
                return new InuitHunters(g);
            return null;
        }
    }
}
