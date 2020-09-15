using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class SaveVillage
    {
        protected OpenFileDialog ofd = new OpenFileDialog();
        protected SaveFileDialog sfd = new SaveFileDialog();
        protected Village villageState;
        protected string fileName;
        protected string savePath;
        protected string json;
        protected string villageSaved;
        public SaveVillage(Village village)
        {
            villageState = village;
        }
        public void saveState(Village village)
        {
            villageState = village;
            villageSaved = JsonConvert.SerializeObject(villageState);
            sfd.Filter = "aov|*.aov";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                savePath = sfd.FileName;
            }
            if (savePath != null)
            {
                using (Stream s = File.Open(savePath, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                    sw.Write(villageSaved);
            }
            else
            {
                return;
            }

        }

        public Village OpenState()
        {

        }
    }
}
