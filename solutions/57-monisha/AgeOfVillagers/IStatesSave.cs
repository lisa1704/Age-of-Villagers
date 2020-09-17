using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public interface ISatesSave
    {
        void executeSave();
    }

    public struct VillageProperties
    {
        public string name;
        public List<Point> House_point;
        public List<Point> Tree_point;
        public List<Point> Waterresource_point;
    }
    /*public class VillageProperties
    {
        public string name;
        public List<Point> House_point;
        public List<Point> Tree_point;
        public List<Point> Waterresource_point;
    }*/

    public class SaveVillage : ISatesSave
    {
        VillageProperties village;
        public SaveVillage(VillageProperties village)
        {
            this.village = village;
        }
        public void executeSave()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"E:\IUT CLASS\Design Pattern Lab\AOVSaveFiles\";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "*.aov";
            saveFileDialog.DefaultExt = "aov";           
            saveFileDialog.Filter = "AoV file(*.aov)| *.aov";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream AOVStream = saveFileDialog.OpenFile();
                using (StreamWriter sw = new StreamWriter(AOVStream))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(sw, village);
                    sw.Close();
                }
                AOVStream.Close();
            }
        }
    }
}
