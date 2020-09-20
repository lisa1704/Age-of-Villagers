using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class Nation
    {
        private readonly string nationtype;
        //private Panel drawingBoard;
        public INation nation;

        public Nation()
        {

        }

        public Nation(string nationtype)
        {
            if(nationtype == "Arab Beduins")
            {
                nation = new ArabBeduin();
            }
            else if(nationtype == "Bangladeshi Farmer")
            {
                nation = new BdFarmer();

            }
            else if (nationtype == "Egyptian King ")
            {
                nation = new EgyptianKing();

            }

        }
        public INation getnationtype()
        {
            return nation;
        }
    }
}
