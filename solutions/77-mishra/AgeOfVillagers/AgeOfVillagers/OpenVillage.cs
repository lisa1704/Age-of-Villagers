using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class OpenVillage : IVillage
    {
        private VillageState villageState;
        public void execute()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                Stream stream = openFile.OpenFile();
                using (StreamReader streamReader = new StreamReader(stream))
                {
                    string json = streamReader.ReadToEnd();
                }
            }
        }
    }
}
