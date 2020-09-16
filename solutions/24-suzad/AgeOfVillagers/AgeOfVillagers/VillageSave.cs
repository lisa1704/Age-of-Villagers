using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class VillageSave
    {
        public static void saveVillage <Village> (string filePath, Village objectToWrite, bool append = false)
        {
            var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite,Formatting.Indented);
            System.IO.File.WriteAllText(filePath, contentsToWriteToFile);
        }
        public static void openVillage(string filePath)
        {
            Village village = JsonConvert.DeserializeObject<Village>(File.ReadAllText(@"D:\Suzad\Books & notes\3-1\S.aov"));
            MessageBox.Show(village.village);
        }
    }
}
