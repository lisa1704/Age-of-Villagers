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
    public class Save_Village
    {
        Village village;

        public Save_Village(Village villageName)
        {
            this.village = villageName;

        }

        public void action()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"E:\3.1\5th Semester\SWE 4502 (Design Pattern Lab)\GitHub\age-of-villagers-swe-17\solutions\75-arnob\Age of Villagers\Village";
            sfd.FileName = " *.aov";
            sfd.DefaultExt = "aov";
            sfd.Filter = "aov file(*.aov)|*.aov";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream stream = sfd.OpenFile();
                using (StreamWriter streamWriter = new StreamWriter(stream))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(streamWriter, village);
                    streamWriter.Close();
                }
                stream.Close();
            }
        }
    }
}
