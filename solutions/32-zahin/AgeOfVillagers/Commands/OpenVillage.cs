using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AgeOfVillagers
{
    class OpenVillage : ICommand
    {
        public VillageState state;
        public void execute()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = openFileDialog1.OpenFile();
                using (StreamReader sr = new StreamReader(fileStream))
                {
                    string json = sr.ReadToEnd();
                    state = JsonConvert.DeserializeObject<VillageState>(json);
                }
            }
        }
        public VillageState getVillage ()
        {
            return state;
        }
    }
}
