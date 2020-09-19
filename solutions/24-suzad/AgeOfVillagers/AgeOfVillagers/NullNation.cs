using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class NullNation : INation
    {
        public void setRadioButtonOption(AgeOfVillagersForm ageOfVillagersForm)
        {
            MessageBox.Show("Select proper nation!!");
        }

        public void setTerrain(AgeOfVillagersForm ageOfVillagersForm)
        {
        }
    }
}
