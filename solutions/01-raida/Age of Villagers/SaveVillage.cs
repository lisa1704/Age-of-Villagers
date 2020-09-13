using Newtonsoft.Json;
using System.IO;


namespace Age_of_Villagers
{
    class SaveVillage : ICommandVillage
    {
        village village;
        private void get_state(INation nation)
        {
            village.name = nation.get_villagename();
            village.tree_points = nation.get_tree();
            village.house_points = nation.get_house();
            village.river_points = nation.get_river();
        }

        public void execute(string path, INation nation)
        {
            this.get_state(nation);

            using (StreamWriter file = File.CreateText(path+".aov"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, village);
            }
        }
    }
}
