using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Age_of_villagers
{
    public interface Icommand
    {
        void execute();
    }
    public struct village
    {
        public string name;
        public List<Point> house_point;
        public List<Point> tree_point;
        public List<Point> waterresource_point;
    }
    public class Savevillage : Icommand
    {
        village village;
        public Savevillage(village village)
        {
            this.village = village;
        }
        public void execute()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"E:\Dp_Assignment_Age_of_villagers\save\";
            sfd.RestoreDirectory = true;
            sfd.FileName = "*.aov";
            sfd.DefaultExt = "aov";
            sfd.Filter = "AoV file(*.aov)| *.aov";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = sfd.OpenFile();
                using (StreamWriter sw = new StreamWriter(fileStream))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(sw, village);
                    sw.Close();
                }
                fileStream.Close();
            }
           
        }
    }
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
