using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;

namespace Age_of_Villagers
{
    public class VillageConditionSave : IVillage
    {
        private VillageCondition villageCondition;

        public  VillageConditionSave(VillageCondition villageCondition)
        {
            this.villageCondition = villageCondition;
        }
        public void PerformOperation()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "*.aov";
            saveFileDialog.DefaultExt = "aov";
            saveFileDialog.Filter = "AoV file(*.aov)| *.aov";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = saveFileDialog.OpenFile();
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    serializer.Serialize(streamWriter, villageCondition);
                    streamWriter.Close();
                }
                fileStream.Close();
            }
          
        }
    }
}
