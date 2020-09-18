using AgeOfVillagers.Interface;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class AOV : IGames
    {
        public void createVillage(Panel drawing_panel, System.Windows.Forms.Label village_name,string sVillageName)
        {
            village_name.Text = sVillageName;
            drawing_panel.Invalidate();
        }

        public List<IItem> openVillage(string selectedNation, Label villageName)
        {
            return null;
        }

        public void saveVillage(List<IItem> itemList, string villageName)
        {
           
        }
    }
}
