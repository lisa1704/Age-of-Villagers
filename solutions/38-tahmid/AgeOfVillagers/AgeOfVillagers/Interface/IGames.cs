using AgeOfVillagers.Interface;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    interface IGames
    {
        public void createVillage(Panel drawing_panel, System.Windows.Forms.Label village_name,string sVillageName);
        public void saveVillage(List<DrawnItemsInformation> drawnItemsInfoList, string villageName);
        public List<IItem> openVillage(String selectedNation, Label villageName,State previouslySavedState, Graphics graphics, Pen pen);
    }
}
