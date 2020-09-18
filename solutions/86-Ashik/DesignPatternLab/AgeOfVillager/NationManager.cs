using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    class NationManager
    {
        private readonly string myNation;
        private Graphics g;

        public NationManager(string myNation, Graphics graphics)
        {
            this.myNation = myNation;
            this.g = graphics;
        }

        public void Draw(MouseEventArgs e)
        {
            if(myNation == "Bangladeshi Farmers")
            {
                BDFarmersTree bdt = new BDFarmersTree(g);
                bdt.draw(e);
            }
            else if(myNation == "Egyptian Kings")
            {
                EgyptianKingsTree ekt = new EgyptianKingsTree(g);
                ekt.draw(e);
            }
            else if(myNation == "Arab Bedouins")
            {
                ArabBedouinsTree abt = new ArabBedouinsTree(g);
                abt.draw(e);
            }
            else if(myNation == "Inuit Hunters")
            {
                MessageBox.Show("Can not plant trees");
            }
        }
    }
}
