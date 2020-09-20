using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class VillagerManager
    {
        private readonly Village village;

        public VillagerManager(Village village)
        {
            this.village = village;
        }
        public void saveVillage()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "AgeOfVillagers|*.aov";
            saveFileDialog.Title = "Save Village";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                var settings = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                };
                var dataString = JsonConvert.SerializeObject(village, Formatting.Indented, settings);
                System.IO.File.WriteAllText(saveFileDialog.FileName, dataString);
            }
        }
        public void loadVillage(Graphics g, Pen p)
        {
            g.Clear(village.nation.getTerrainColor());
            foreach (var tree in village.trees)
            {
                village.nation.getTree(tree).draw(g, p);
            }
            foreach (var house in village.houses)
            {
                village.nation.getHouse(house).draw(g, p);
            }
            foreach (var watersource in village.waterSources)
            {
                village.nation.getWaterSource(watersource).draw(g, p);
            }
        }
    }
}
