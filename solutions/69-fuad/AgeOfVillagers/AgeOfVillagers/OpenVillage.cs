using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.Open
{
    public class OpenVillage
    {
        Village vill;
        public Village getVill()
        {
            OpenFileDialog openfileddialog = new OpenFileDialog();
            if (openfileddialog.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = openfileddialog.OpenFile();

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
