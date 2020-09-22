using System.Windows.Forms;

namespace ageOfVillagers
{
    public class Village
    {
        private string nation;
        private string villagename;
        
        public void CreateVillage(string nation, string villagename)
        {
            this.nation = nation;
            this.villagename = villagename;
        }
        public void Open(string villagename)
        {
            VillageState state = new VillageState();
            state.SetState(villagename);
            //openning the village
        }
        public void Save()
        {
            SaveVillageState s = new SaveVillageState();
            s.Save();
        }
    }
}