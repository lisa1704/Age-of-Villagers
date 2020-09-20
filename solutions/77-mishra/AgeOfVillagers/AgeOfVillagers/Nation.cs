using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class Nation
    {
        private string nationtype;
        private Panel drawingBoard;
        public INation nation;

        public Nation(string nationtype, Panel drawingBoard)
        {
            this.nationtype = nationtype;
            this.drawingBoard = drawingBoard;

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
