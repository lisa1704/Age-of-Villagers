using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AgeOfVillagers
{
    public class SaveVillageState : ICommandVillage
    {
      private  VillageState village;

        public SaveVillageState(VillageState village)
        {
            this.village = village;
        }

        public void Execute()
        {
            SaveFileDialog _savefiledg = new SaveFileDialog();
            _savefiledg.InitialDirectory = @"E:\Dp_Assignment_Age_of_villagers\save\";
            _savefiledg.RestoreDirectory = true;
            _savefiledg.FileName = "*.aov";
            _savefiledg.DefaultExt = "aov";
            _savefiledg.Filter = "AoV file(*.aov)| *.aov";
            if (_savefiledg.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = _savefiledg.OpenFile();
                using (StreamWriter _sw = new StreamWriter(fileStream))
                {
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    serializer.Serialize(_sw, village);
                    _sw.Close();
                }
                fileStream.Close();
            }

        }
    }
}
