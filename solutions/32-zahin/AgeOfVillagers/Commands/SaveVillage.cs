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
    class SaveVillage : ICommand
    {
        public void execute()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "*.aov";
            saveFileDialog1.DefaultExt = "aov";
            saveFileDialog1.Filter = "AOV files (*.aov)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.ShowDialog();
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    //VillageState state = new VillageState();
                    serializer.Serialize(sw, null);
                    sw.Close();
                }
                fs.Close();
        }
    }
}
