using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class SaveVillage : IVillage
    {
        public VillageState villagestate;

        public SaveVillage(VillageState villagestate)
        {
            this.villagestate = villagestate;
        }
        public void execute()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = @"K:\AgeOfVillagers\File Saving";
            saveFile.RestoreDirectory = true;
            saveFile.FileName = "*.aov";
            saveFile.Filter = "AOV files(*.aov)| *.aov";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveFile.OpenFile();
                using(StreamWriter streamWriter = new StreamWriter(stream))
                {
                    Newtonsoft.Json.JsonSerializer jsonSerializer = new Newtonsoft.Json.JsonSerializer();
                    jsonSerializer.Serialize(streamWriter, villagestate);
                    streamWriter.Close();
                }
                stream.Close();
            }
        }

    }
}
