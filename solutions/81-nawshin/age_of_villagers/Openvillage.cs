using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace age_of_villagers
{
    public class Openvillage 
    {
        SaveVillage village;
        public void execute()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = ofd.OpenFile();
                using (StreamReader sr = new StreamReader(fileStream))
                {
                    string json = sr.ReadToEnd();
                    village = JsonConvert.DeserializeObject<SaveVillage>(json);
                }
            }
        }

        public SaveVillage get_village()
        {
            return this.village;
        }
    }
}
