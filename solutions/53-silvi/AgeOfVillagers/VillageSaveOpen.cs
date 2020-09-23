using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AgeOfVillagers
{
    public class VillageSaveOpen
    {
        private Items myItems;
        Items savedVillageItems;

        public VillageSaveOpen(Items myItems)
        {
            this.myItems = myItems;
        }



        public void saveMyVillage()
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.InitialDirectory = @"F:\sem 3.1\Design pattern\53-silvi";
            savefiledialog.RestoreDirectory = true;
            savefiledialog.FileName = "*.aov";
            savefiledialog.DefaultExt = "aov";
            savefiledialog.Filter = "AoV file(*.aov) | *.aov";

            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = savefiledialog.OpenFile();
                using (StreamWriter streamWriter = new StreamWriter(stream))
                {
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    jsonSerializer.Serialize(
                        streamWriter, myItems);
                    streamWriter.Close();
                }
                stream.Close();
            }
        }

        public void openMyVillage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream openStream = openFileDialog.OpenFile();
                using (StreamReader streamReader = new StreamReader(openStream))
                {
                    string jsonDeserializer = streamReader.ReadToEnd();
                    savedVillageItems = JsonConvert.DeserializeObject<Items>(jsonDeserializer);
                }
            }

        }

        public Items getmyVillage()
        {
            return savedVillageItems;
        }
    }

    public struct Items
    {
        public string NationName;
        public string VillageName;
        public Color VillageColor;
        public List<Point> House;
        public List<Point> Tree;
        public List<Point> WaterSource;
    }
}