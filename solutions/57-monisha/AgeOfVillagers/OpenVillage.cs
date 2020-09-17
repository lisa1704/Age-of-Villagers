using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
   public class OpenVillage : ISatesSave
    {
        VillageProperties villageproperties;
        public void executeSave()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream AOVStream = ofd.OpenFile();
                using (StreamReader streamReader = new StreamReader(AOVStream))
                {
                    string json = streamReader.ReadToEnd();
                    villageproperties = JsonConvert.DeserializeObject<VillageProperties>(json);
                }
            }
          /*   public VillageProperties get_village()()
            {
                return villageproperties;
            }*/
        }

    }
}
