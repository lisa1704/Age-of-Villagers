using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace Age_of_Villagers.Village_Saving
{
    public class VillageOpen : ICommand
    {

        OpenFileDialog ofd = new OpenFileDialog();
        VillageState newVillageState;
        string fileName;
        string json;

        public VillageOpen(VillageState villageState)
        {
            newVillageState = villageState;
        }
        public void ExecuteCommand()
        {
        }

        public VillageState ReformVillage()
        {
            ofd.Filter = ".aov|*.aov";
            ofd.Title = "Open an AOV File";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
            }

            Stream stream = File.Open(fileName, FileMode.Open);
            StreamReader stream_reader = new StreamReader(stream);
            json = stream_reader.ReadLine();
            stream_reader.Close();
            return JsonConvert.DeserializeObject<VillageState>(json);
        }

    }
}
