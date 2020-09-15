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

        }
    }
}
