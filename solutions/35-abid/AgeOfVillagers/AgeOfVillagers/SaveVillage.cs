using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class SaveVillage : IOpenSave
    {

        private VillageState villageState;
        public SaveVillage(VillageState villageState)
        {
            this.villageState = villageState;
        }

        public object JsonSerializer { get; private set; }

        public void execute()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"D:\AoV";
            sfd.RestoreDirectory = true;
            sfd.FileName = villageState.Vname + ".aov";
            sfd.DefaultExt = "aov";
            sfd.Filter = "AoV file(*.aov) | *.aov";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream AoVstream = sfd.OpenFile();
                using (StreamWriter streamWriter = new StreamWriter(AoVstream))
                {
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    jsonSerializer.Serialize(streamWriter, villageState);
                    streamWriter.Close();
                }
                AoVstream.Close();
            }
        }
    }

}
