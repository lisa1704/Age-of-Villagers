using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    interface IGames
    {
        public void createVillage(Panel drawing_panel, System.Windows.Forms.Label village_name,string sVillageName);
        public void saveVillage(List<IItem> itemList, string villageName);
        public List<IItem> openVillage(String selectedNation, Label villageName);
    }
}
