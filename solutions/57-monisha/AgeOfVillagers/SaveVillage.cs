using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    /*public class VillageProperties
    {
        public string name;
        public List<Point> House_point;
        public List<Point> Tree_point;
        public List<Point> Waterresource_point;
    }*/

    public class SaveVillage : IStatesVillage
    {
        VillageProperties village;
        public SaveVillage(VillageProperties village)
        {
            this.village = village;
        }
        public void executeAction()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"E:\IUT CLASS\Design Pattern Lab\AOVSaveFiles\";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "*.aov";
            saveFileDialog.DefaultExt = "aov";           
            saveFileDialog.Filter = "AoV file(*.aov)| *.aov";
         
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream AOVStream;
                if ((AOVStream = saveFileDialog.OpenFile()) != null)
                {
                    using (StreamWriter sw = new StreamWriter(AOVStream))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(sw, village);
                        sw.Close();
                    }
                    AOVStream.Close();
                }
            }
        }
    }
}
