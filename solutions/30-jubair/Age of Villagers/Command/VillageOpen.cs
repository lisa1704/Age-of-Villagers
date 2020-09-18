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
        VillageEdit newVillageEdit;
        string fileName;
        string json;

        public VillageOpen(VillageEdit villageEdit)
        {
            newVillageEdit = villageEdit;
        }
        public void ExecuteCommand()
        {
        }

        public VillageEdit ReformVillage()
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
            return JsonConvert.DeserializeObject<VillageEdit>(json);
        }

    }
}
