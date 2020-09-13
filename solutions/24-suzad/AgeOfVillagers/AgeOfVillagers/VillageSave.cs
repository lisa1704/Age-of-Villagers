using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class VillageSave
    {
        AgeOfVillagersForm ageOfVillagersForm = new AgeOfVillagersForm();
        public string nation;
        public string village;
        public Panel drawingSpace;
        public void setFields()
        {
            nation = ageOfVillagersForm.lblNationName.Text;
            village = ageOfVillagersForm.lblVillageName.Text;
            drawingSpace = ageOfVillagersForm.pnlDrawingSpace;
        }

    }
}
