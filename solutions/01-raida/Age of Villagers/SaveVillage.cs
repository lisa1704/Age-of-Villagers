using Newtonsoft.Json;
using System.IO;


namespace Age_of_Villagers
{
    public class SaveVillage : ICommandVillage
    {
        village village;
        private void get_state(INation nation)
        {
            village.name = nation.get_villagename();
            village.tree_points = nation.get_tree();
            village.house_points = nation.get_house();
            village.river_points = nation.get_river();
        }

        public village execute(string path, INation nation)
        {
            
                this.get_state(nation);
            
            if (Path.GetExtension(path).Equals(".aov")) { }
            else
            {
                path = path + ".aov";
            }
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, village);
            }
            return village;
        }
    }
}
