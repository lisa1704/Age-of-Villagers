using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class OpenVillage : IOpenSave
    {
        VillageState savedVillageState;
        public void execute()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Stream AoVstream = openFile.OpenFile();
                using (StreamReader stream = new StreamReader(AoVstream))
                {
                    string data = stream.ReadToEnd();
                    savedVillageState = JsonConvert.DeserializeObject<VillageState>(data);
                }
            }
        }
        public VillageState getsavedvillage()
        {
            return savedVillageState;
        }
    }
}
