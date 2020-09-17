using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace AgeOfVillagers90
{
    public class VillageSave : IVillageSave
    {
        private VillageItem villageItem;

        public VillageSave(VillageItem villageItem)
        {
            this.villageItem = villageItem;
        }

        public object JsonSerializer { get; private set; }

        public void saved()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"F:\Soft Studies\S 3.1\Design Pattern Materials\SavePictureAOV\";
            sfd.RestoreDirectory = true;
            sfd.FileName = "*.aov";
            sfd.DefaultExt = "aov";
            sfd.Filter = "AoV file(*.aov) | *.aov";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Stream aov90strm = sfd.OpenFile();
                using (StreamWriter streamWriter = new StreamWriter(aov90strm)) 
                {
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    jsonSerializer.Serialize(streamWriter, villageItem);
                    streamWriter.Close();
                }
                aov90strm.Close();
            }
        }
    }
}
