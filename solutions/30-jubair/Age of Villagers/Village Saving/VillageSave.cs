using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json;

namespace Age_of_Villagers.Village_Saving
{
    public class VillageSave
    {
         SaveFileDialog sfd = new SaveFileDialog();
         VillageState newVillageState;
         string path;
         string villageSerialized;

        public VillageSave(VillageState villageState)
        {
            newVillageState = villageState;
        }

        public void SaveVillage(VillageState village)
        {
            newVillageState = village;
            villageSerialized = JsonConvert.SerializeObject(newVillageState);
            sfd.Filter = ".aov|*.aov";
            sfd.Title = "Save AOV File";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
                using Stream aovStream = File.Open(path, FileMode.Create);
                using StreamWriter stream_writer = new StreamWriter(aovStream);
                stream_writer.Write(villageSerialized);
            }
            else
            {
                return;
            }
        }


    }
}
