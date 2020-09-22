using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Of_Villagers.Command
{
    public class SaveVillage : ICommand
    {
        Village _village;
        public SaveVillage(Village village)
        {
            _village = village;

        }

        public void execute()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = @"C:\Users\User\Desktop\age-of-villagers\solutions\34-meem\Files";
            saveFile.Title = "Save aov files Files";
            saveFile.CheckFileExists = false;
            saveFile.CheckPathExists = false;
            saveFile.DefaultExt = "aov";
            saveFile.Filter = "Aov files (*.aov)|*.aov|All files (*.*)|*.*";
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string json = JsonConvert.SerializeObject(_village);
                System.IO.File.WriteAllText(saveFile.FileName, json);
            }

           



        }
    }
}
