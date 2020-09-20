using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class OpenVillageState : ICommandVillage
    {
        private VillageState villagestate;
        public void Execute()
        {
            OpenFileDialog _Openfiledg = new OpenFileDialog();

            if (_Openfiledg.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = _Openfiledg.OpenFile();
                using (StreamReader sr = new StreamReader(fileStream))
                {
                    string json = sr.ReadToEnd();
                    villagestate = JsonConvert.DeserializeObject<VillageState>(json);
                }
            }
        }

        public VillageState get_villageState()
        {
            return this.villagestate;
        }
    }
}

