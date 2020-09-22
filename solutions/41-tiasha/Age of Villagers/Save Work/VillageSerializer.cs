using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    class VillageSerializer
    {
        Village _village;

        public void saveState(Village village)
        {
            _village = village;

            string villageSerialized = JsonConvert.SerializeObject(village);
            System.IO.File.WriteAllText("G:/C#/" + village.getName() + ".aov", villageSerialized);
            Debug.WriteLine(villageSerialized);
        }

        public Village openState()
        {
            Village village;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"G:\C#\",
                Title = "Open a Village",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "aov",
                Filter = "aov files (*.aov)|*.aov",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var file = openFileDialog.FileName;

                village = JsonConvert.DeserializeObject<Village>(File.ReadAllText(file));

                return village;
            }

            return null;
        }
    }
}
