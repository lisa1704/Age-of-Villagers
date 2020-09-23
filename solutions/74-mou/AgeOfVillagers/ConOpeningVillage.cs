using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class ConOpeningVillage : IVillageCommand
    {
        ItemsOfVillage SavedVItems;
        public void ExecuteCommand()
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            if(openfiledialog.ShowDialog() == DialogResult.OK)
            {
                Stream streamAoV = openfiledialog.OpenFile();
                using(StreamReader streamreader = new StreamReader(streamAoV))
                {
                    string readjson = streamreader.ReadToEnd();
                    SavedVItems = JsonConvert.DeserializeObject<ItemsOfVillage>(readjson);
                }
            }
        }

        public ItemsOfVillage GetSavedItemsOfVillage()
        {
            return SavedVItems;
        }
    }
}
