using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace empty_project
{
    internal class SelectNation
    {
        public INation GetNation(string nation)
        {
            if (nation == "BangladeshiFarmers")
                return new BangladeshiFarmers();
            else if (nation == "ArabBedouin")
                return new ArabBedouin();
            else if (nation == "EgyptianKings")
                return new EgyptianKings();
            else if (nation == "InuitHunters")
                return new InuitHunters();
            throw new Exception();
        }
    }
}
