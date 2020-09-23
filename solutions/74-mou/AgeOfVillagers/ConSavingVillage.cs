using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace AgeOfVillagers
{
    public class ConSavingVillage : IVillageCommand
    {
        ItemsOfVillage vitems;
        public ConSavingVillage(ItemsOfVillage vitems)
        {
            this.vitems = vitems;
        }
        public object JsonSerializer { get; private set; }
        public void ExecuteCommand()
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            {
                savefiledialog.InitialDirectory = @"E:\Study\3-1\Labs\AoV Saved Village Files";
                savefiledialog.RestoreDirectory = true;
                savefiledialog.FileName = "*.aov";
                savefiledialog.DefaultExt = "aov";
                savefiledialog.Filter = "AoV File(*.aov) | *.aov";
            };

            if(savefiledialog.ShowDialog() == DialogResult.OK)
            {
                Stream streamAoV = savefiledialog.OpenFile();
                using (StreamWriter streamwriter = new StreamWriter(streamAoV))
                {

                    JsonSerializer jsonserializer = new JsonSerializer();
                    jsonserializer.Serialize(streamwriter, vitems);
                    streamwriter.Close();

                }
                streamAoV.Close();
            }

        }
    }
}
