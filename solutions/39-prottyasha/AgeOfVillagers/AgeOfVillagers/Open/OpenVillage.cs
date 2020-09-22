using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.Open
{
    class OpenVillage
    {
        Village vill;
        public Village getVill()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = ofd.OpenFile();
                //vill.village_name = ofd.FileName;
                using (StreamReader sr = new StreamReader(fileStream))
                {
                    string json = sr.ReadToEnd();
                    vill = JsonConvert.DeserializeObject<Village>(json);
                }
            }
            Console.WriteLine(vill);
            return vill;
        }
    }
}
