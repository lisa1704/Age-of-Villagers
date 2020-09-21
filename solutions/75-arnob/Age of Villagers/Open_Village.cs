using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class Open_Village
    {
        Village village;

        public void action()
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Stream stream = open.OpenFile();
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    string json = streamReader.ReadToEnd();
                    village = JsonConvert.DeserializeObject<Village>(json);
                }

            }

        }
        public Village openVillage()
        {
            return this.village;
        }
    }
}
