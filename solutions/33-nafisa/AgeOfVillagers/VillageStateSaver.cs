using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class VillageStateSaver : ICommand
    {
        private VillageState village;
        SaveFileDialog imgDialog;
        public VillageStateSaver(VillageState village)
        {
            this.village = village;
        }
        public void execute()
        {
            this.imgDialog = new SaveFileDialog();
           // imgDialog.InitialDirectory = "";
            imgDialog.FileName = "*.aov";
            imgDialog.DefaultExt = "aov";
            imgDialog.Filter = "Aov Files | *.aov";
            if (imgDialog.ShowDialog()== DialogResult.OK)
            {
                Stream filestream = imgDialog.OpenFile();
                using (StreamWriter _sw = new StreamWriter(filestream))
                {
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    serializer.Serialize(_sw, village);
                    _sw.Close();
                }
                filestream.Close();
            }
        }
    }
}
