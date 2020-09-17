using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class InuitHunterNation : INation
    {
        public void setRadioButtonOption(AgeOfVillagersForm ageOfVillagersForm)
        {
            ageOfVillagersForm.radiobtnHouse.Enabled = true;
            ageOfVillagersForm.radiobtnTree.Enabled = false;
            ageOfVillagersForm.radiobtnWaterSource.Enabled = false;
        }

        public void setTerrain(AgeOfVillagersForm ageOfVillagersForm)
        {
            ageOfVillagersForm.pnlDrawingSpace.BackColor = Color.White;
        }
    }
}
