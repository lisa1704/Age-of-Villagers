using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AgeOfVillagers
{
    class SaveVillage : ICommand
    {
        public string villagename;
        public List<Point> house;
        public List<Point> tree;
        public List<Point> water;
        public VillageState state;
        public SaveVillage(VillageState state)
        {
            this.state = state;
        }
        public void execute()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "*.aov";
            saveFileDialog1.DefaultExt = "aov";
            saveFileDialog1.Filter = "AOV files (*.aov)|*.aov";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.ShowDialog();
                Stream fs = saveFileDialog1.OpenFile();
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(sw, state);
                    sw.Close();
                }
                fs.Close();
        }
    }
}
