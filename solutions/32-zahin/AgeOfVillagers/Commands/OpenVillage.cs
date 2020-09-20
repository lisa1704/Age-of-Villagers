using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AgeOfVillagers
{
    class OpenVillage : ICommand
    {
        public VillageState state;
        public OpenVillage(VillageState state)
        {
            this.state = state;
        }
        public void execute()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            FileStream fs = (FileStream)openFileDialog1.OpenFile();
            using (StreamReader sr = new StreamReader(fs))
            {
                string json = sr.ReadToEnd();
                state = JsonConvert.DeserializeObject<VillageState>(json);
            }
        }
    }
}
