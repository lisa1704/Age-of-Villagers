using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace age_of_villagers
{
    public class Save
    {
        SaveVillage village;

        public Save(SaveVillage villageName)
        {
            this.village = villageName;

        }

        public void action()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\Users\User-PC\source\repos\age-of-villagers-swe-17\solutions\81-nawshin\age_of_villagers\SavedVillages";
            sfd.FileName = "*.txt";
            sfd.DefaultExt = "txt";
            sfd.Filter = "txt file(*.txt)|*.txt";
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                Stream stream = sfd.OpenFile();
                using (StreamWriter streamWriter=new StreamWriter(stream))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(streamWriter, village);
                    streamWriter.Close();
                }
                stream.Close();
            }
        }
    }
}
