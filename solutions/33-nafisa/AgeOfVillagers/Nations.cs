﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class Nations
    {
        private string Nationtype;
        private Panel Drawingpanel;
        public INation nation;


        public Nations(string Nationtype, Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
            this.Nationtype = Nationtype;

            if (Nationtype == "Bangladeshi Farmers")
            {
                
                nation = new BangladeshiFarmers(Drawingpanel);
            }
            else if (Nationtype == "Arab Beduins")
            {
               
                nation = new ArabBeduins(Drawingpanel);
            }
            else if (Nationtype == "Egyptian Kings")
            {
               
                nation = new EgyptianKings(Drawingpanel);
            }
            else if (Nationtype == "Inuit Hunters")
            {
                
                nation = new InuitHunters(Drawingpanel);
            }
            else 
            {
                nation = new NullNation();
            }
        }
        public INation getNation()
        {
            return nation;
        }

    }
}
