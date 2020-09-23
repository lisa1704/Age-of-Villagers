using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace age_of_villagers
{
    class Open_village
    {
        public Village Opvill()
        {
            Village village;


            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"E:\Villages\",
                Title = "Open Village",
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
