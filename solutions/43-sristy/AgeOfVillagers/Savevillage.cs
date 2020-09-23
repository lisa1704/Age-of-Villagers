using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Age_of_villagers
{
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
}
