using Newtonsoft.Json;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public class OpenVillage : ICommandVillage
    {
        village village;
        public void execute(string path,INation nation)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                village= JsonConvert.DeserializeObject<village>(json);
            }
            if (nation != null)
            {
                this.set_state(nation);
            }
            else
            {
                MessageBox.Show("Must select a nation type");
            }
        }

        private void set_state(INation nation)
        {
            nation.set_villagename(village.name);
            foreach (Point p in village.tree_points)
                nation.draw_tree(p);
            foreach (Point p in village.house_points)
                nation.draw_house(p);
            foreach (Point p in village.river_points)
                nation.draw_river(p);
            
        }
    }
}
