using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace age_of_villagers
{
    public class Openvillage 
    {
        SaveVillage village;

        public void action()
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog()==DialogResult.OK)
            {
                Stream stream = open.OpenFile();
                using(StreamReader streamReader=new StreamReader(stream))
                {
                    string json = streamReader.ReadToEnd();
                    village = JsonConvert.DeserializeObject<SaveVillage>(json); 
                }

            }
          
        }
        public SaveVillage openVillage()
        {
            return this.village;
        }
    }
}
