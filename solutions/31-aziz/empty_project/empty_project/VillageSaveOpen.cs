using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Newtonsoft.Json;
using System.IO;

namespace empty_project
{
    public class VillageSaveOpen
    {
        protected Village villageState;
        protected string villageSerialized;
        protected OpenFileDialog open = new OpenFileDialog();
        protected SaveFileDialog save = new SaveFileDialog();
        protected string pathSave;
        protected string file;
        protected string jsonText;
        public VillageSaveOpen(Village village)
        {
            villageState = village;
        }
        public void saveVillageState(Village village)
        {
            villageState = village;
            villageSerialized = JsonConvert.SerializeObject(villageState);
            save.Filter = "AoV|*.AoV";
            if(save.ShowDialog()==DialogResult.OK)
            {
                pathSave = save.FileName;
            }
            if(pathSave != null)
            {
                using (Stream stream = File.Open(pathSave, FileMode.Create))
                using (StreamWriter streamWriter = new StreamWriter(stream))
                streamWriter.Write(villageSerialized);
            }
            else
            {
                return;
            }
        }
        public Village openVillageState()
        {
            open.Filter = "AoV|*.AoV";
            if (open.ShowDialog() == DialogResult.OK)
            {
                    file = open.FileName;
            }
            if (file == null)
            {
                    return villageState;
            }
            Stream stream = File.Open(file, FileMode.Open);
            StreamReader streamreader = new StreamReader(stream);
            jsonText = streamreader.ReadLine();
            streamreader.Close();
            return JsonConvert.DeserializeObject<Village>(jsonText);
        }
    }
}
