using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Of_Villagers.FileManager
{
    public class File_Manager
    {

        public void saveVillage(Village village)
        {
            var jsonVillage = JsonConvert.SerializeObject(village);

            // open savefileDialog to save the village in preferred location


            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = @"E:\",
                Title = "Save a village (.json file)",


                CheckPathExists = true,

                DefaultExt = "aov",
                Filter = "aov files (*.aov)|*.aov",
                FilterIndex = 2,
                RestoreDirectory = true,

            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //write the village.json in the selected location

                var filePath = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(filePath, jsonVillage);




            }

        }

        public void openVillage()
        {

        }

    }
}
