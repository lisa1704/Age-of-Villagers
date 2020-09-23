using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.Save
{
    class SaveVillage
    {
        Village vill;
        public SaveVillage(Village vill)
        {
            this.vill = vill;
        }
        public void SaveFile()
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = "*.aov";
            savefiledialog.Filter = "AoV file(*.aov)| *.aov";
            savefiledialog.DefaultExt = "aov";
            savefiledialog.Title = "Save an aov File";
            savefiledialog.InitialDirectory = @"H:\aov_saved\";
            savefiledialog.RestoreDirectory = true;
            savefiledialog.ShowDialog();
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = savefiledialog.OpenFile();
                using (StreamWriter sw = new StreamWriter(fileStream))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(sw, vill);
                    sw.Close();
                }
                fileStream.Close();
            }
        }
    }
}