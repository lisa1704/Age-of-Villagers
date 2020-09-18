using AgeOfVillagers.Interface;
using AgeOfVillagers.Model_Class_Folder;
using Newtonsoft.Json;
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
            StateModel stateModel = new StateModel()
            {
                VillageName = villageName,
                ItemList=itemList

            };

            // Convert BlogSites object to JOSN string format  
            string jsonData = JsonConvert.SerializeObject(stateModel);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "save village|*.aov";
            saveFileDialog1.Title = "Save village";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                var dataString = JsonConvert.SerializeObject(stateModel, Formatting.Indented);
                System.IO.File.WriteAllText(saveFileDialog1.FileName, dataString);
            }
        }
    }
}
