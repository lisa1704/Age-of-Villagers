using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
   public class OpenVillage : IStatesVillage
    {
        public VillageProperties villageproperties;
        public void ExecuteAction()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream AOVStream = ofd.OpenFile();
                using (StreamReader streamReader = new StreamReader(AOVStream))
                {
                    string json = streamReader.ReadToEnd();
                    villageproperties = JsonConvert.DeserializeObject<VillageProperties>(json);
                }
            }
            /*  if (openFileDialog.ShowDialog() == DialogResult.OK)
              {
                  //Get the path of specified file
                  filePath = openFileDialog.FileName;

                  //Read the contents of the file into a stream
                  var fileStream = openFileDialog.OpenFile();

                  using (StreamReader reader = new StreamReader(fileStream))
                  {
                      fileContent = reader.ReadToEnd();
                  }
              }*/          
        }
        public VillageProperties GetVillage()
        {
            return villageproperties;
        }
    }
}
