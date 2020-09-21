using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class SaveVillage
    {
        public VillageState villagestate;

        public SaveVillage(VillageState villagestate)
        {
            this.villagestate = villagestate;
        }
        public void execute()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = @"K:\AgeOfVillagers\File Saving";
            saveFile.RestoreDirectory = true;
            saveFile.FileName = "*.aov";
            saveFile.Filter = "AOV files(*.aov)| *.aov";
        }

    }
}
