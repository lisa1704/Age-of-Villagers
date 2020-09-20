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
        SaveFileDialog sfDialog;
       
        private Stream myStream;

        public VillageStateSaver(VillageState village)
        {
            this.village = village;
        }
        public void execute()
        {
            this.sfDialog = new SaveFileDialog();
            sfDialog.RestoreDirectory = true;
            sfDialog.InitialDirectory = "G:/3.1/DP/solutions/33-nafisa/AgeOfVillagers/savedimage";
            sfDialog.FileName = "*.aov";
            sfDialog.DefaultExt = "aov";
            sfDialog.Filter = "Aov File|*.aov";
            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                
                if ((myStream = sfDialog.OpenFile()) != null)
                {
                    using (StreamWriter sw = new StreamWriter(myStream))
                    {
                        Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                        serializer.Serialize(sw, village);
                        sw.Close();
                    }
                    myStream.Close();
                }
            }
        }
    }
}
