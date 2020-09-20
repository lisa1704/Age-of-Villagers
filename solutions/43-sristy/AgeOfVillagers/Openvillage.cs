using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Age_of_villagers
{
    public class Openvillage : Icommand
    {
        village village;
        public void execute()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = ofd.OpenFile();
                using (StreamReader sr = new StreamReader(fileStream))
                {
                    string json = sr.ReadToEnd();
                    village = JsonConvert.DeserializeObject<village>(json);
                }
            }
        }

        public village get_village()
        {
            return this.village;
        }
    }
}
