using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class VillageOpenSave : ICommand
    {
        VillageItems villageItems;
        VillageItems savedvillageItems;
        public VillageOpenSave(VillageItems villageItems)
        {
            this.villageItems = villageItems;
        }
        public void SaveVillage()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"G:\3-1 2020\Design pattern\AoV_Files";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "*.aov";
            saveFileDialog.DefaultExt = "aov";
            saveFileDialog.Filter = "AoV File(*.aov)|*.aov";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream st = saveFileDialog.OpenFile();
                using(StreamWriter stwr = new StreamWriter(st))
                {
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    jsonSerializer.Serialize(stwr,villageItems);
                    stwr.Close();
                }
                st.Close();
            }

        }
        public void OpenVillage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream openSt = openFileDialog.OpenFile();
                using(StreamReader streamReader = new StreamReader(openSt))
                {
                    string jsonDeserializer = streamReader.ReadToEnd();
                    savedvillageItems = JsonConvert.DeserializeObject<VillageItems>(jsonDeserializer);
                }
            }
        }
        public VillageItems GetMyVillageItems()
        {
            return savedvillageItems;
        }
    }

}
