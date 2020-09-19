namespace ageOfVillagers
{
    interface IDraw
    {
        void Draw();
    }
    public class Village: IDraw
    {
        private string nation;
        private string villagename;
        public void Draw(){}
        public void CreateVillage(string nation, string villagename)
        {
            this.nation = nation;
            this.villagename = villagename;
        }
        public void Open(string villagename)
        {
            
        }
        public void Save()
        {
            SaveVillageState s = new SaveVillageState();
            s.save();
        }
    }
}