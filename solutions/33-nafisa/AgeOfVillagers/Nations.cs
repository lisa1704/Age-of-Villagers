using System;
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
                Drawingpanel.BackColor = System.Drawing.Color.LightGreen;
                nation = new BangladeshiFarmers(Drawingpanel);
            }
            else if (Nationtype == "Arab Beduins")
            {
                Drawingpanel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                nation = new ArabBeduins(Drawingpanel);
            }
            else if (Nationtype == "Egyptian Kings")
            {
                Drawingpanel.BackColor = System.Drawing.Color.Yellow;
                nation = new EgyptianKings(Drawingpanel);
            }
            else if (Nationtype == "Inuit Hunters")
            {
                Drawingpanel.BackColor = System.Drawing.Color.LightSkyBlue;
                nation = new InuitHunters();
            }
        }
        public INation getNation()
        {
            return nation;
        }

    }
}
