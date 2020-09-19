using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class VillagerManager
    {
        private readonly Village village;

        public VillagerManager(Village village)
        {
            this.village = village;
        }
        public void saveVillage()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "AgeOfVillagers|*.aov";
            saveFileDialog.Title = "Save Village";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                var settings = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                };
                var dataString = JsonConvert.SerializeObject(village, Formatting.Indented, settings);
                System.IO.File.WriteAllText(saveFileDialog.FileName, dataString);
            }
        }
    }
}
