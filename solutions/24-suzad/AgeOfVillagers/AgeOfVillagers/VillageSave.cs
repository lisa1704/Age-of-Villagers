using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class VillageSave
    {

        public void saveVillage <Village> ( Village objectToWrite, bool append = false)
        {
            var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite, Formatting.Indented);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save aov file";
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "aov";
            saveFileDialog.OverwritePrompt = true;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                
                System.IO.File.WriteAllText(path, contentsToWriteToFile);
            }
        }
    }
}
