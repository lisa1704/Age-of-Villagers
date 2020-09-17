using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BdFarmerNation : INation
    {
        public void setRadioButtonOption(AgeOfVillagersForm ageOfVillagersForm)
        {
            ageOfVillagersForm.radiobtnHouse.Enabled = true;
            ageOfVillagersForm.radiobtnTree.Enabled = true;
            ageOfVillagersForm.radiobtnWaterSource.Enabled = true;
        }

        public void setTerrain(AgeOfVillagersForm ageOfVillagersForm)
        {
            ageOfVillagersForm.pnlDrawingSpace.BackColor = Color.Green;
        }
    }
}
