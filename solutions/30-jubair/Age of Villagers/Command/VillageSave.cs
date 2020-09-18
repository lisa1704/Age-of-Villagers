using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;



namespace Age_of_Villagers.Village_Saving
{
    public class VillageSave : ICommand
    {

        SaveFileDialog sfd = new SaveFileDialog();
        VillageEdit newVillageEdit;
        string path;
        string villageSerialized;
      
        public VillageSave(VillageEdit villageEdit)
        {
            newVillageEdit = villageEdit;
        }


        public void ExecuteCommand()
        {
        }

        public void SaveVillage(VillageEdit village)
        {
            newVillageEdit = village;
            villageSerialized = JsonConvert.SerializeObject(newVillageEdit);
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
