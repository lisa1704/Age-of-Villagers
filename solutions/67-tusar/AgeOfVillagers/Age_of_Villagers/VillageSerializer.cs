using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Age_of_Villagers
{
    class VillageSerializer
    {
        protected OpenFileDialog ofd = new OpenFileDialog();
        protected SaveFileDialog sfd = new SaveFileDialog();
        protected string fileName;
        public void saveState(Village village)
        {
            string villageSerialized = JsonConvert.SerializeObject(village);
            sfd.Filter = "aov|*.aov";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream s = File.Open(sfd.FileName, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(s);
                sw.Write(villageSerialized);
            }
        }
        public Village restoreState()
        {
            ofd.Filter = "aov|*.aov";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
            }
            string json = System.IO.File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<Village>(json);
        }
    }
}
