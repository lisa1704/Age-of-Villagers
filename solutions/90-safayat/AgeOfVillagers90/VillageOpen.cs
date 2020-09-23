using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace AgeOfVillagers90
{
    public class VillageOpen : IVillageSaveOpen
    {
        VillageItem villageItemSave;
        public void Execute()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                Stream aovstream90 = openFile.OpenFile();
                using (StreamReader stream = new StreamReader(aovstream90))
                {
                    string jsonD = stream.ReadToEnd();
                    villageItemSave = JsonConvert.DeserializeObject<VillageItem>(jsonD);
                }
            }
        }

        public VillageItem GetSavedVillage()
        {
            return villageItemSave;
        }
    }
}
