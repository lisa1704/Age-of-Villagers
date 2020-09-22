using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class VillageConditionOpen : IVillage
    {
        private VillageCondition villageCondition;
        public void PerformOperation()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = openFileDialog.OpenFile();
                using (StreamReader stream = new StreamReader(fileStream))
                {
                    string json = stream.ReadToEnd();
                    villageCondition = JsonConvert.DeserializeObject<VillageCondition>(json);
                }
            }
        }
        public VillageCondition GetVillageCondition()
        {
            return this.villageCondition;
        }
    }
}
