using System.Windows.Forms;

namespace ageOfVillagers
{
    interface IDraw
    {
        void Draw(string nationName, string currentselect, int x, int y);
    }
    public class Village: IDraw
    {
        private string nation;
        private string villagename;
        private string work;
        public void Draw(string nationName, string currentselect, int x, int y)
        {
            if (currentselect == "tree") 
            {
                //Tree t = new Tree();
                //t.Draw(x, y);
                work = "Drawing a tree";
            }
            else if (currentselect == "house")
            {
                //House h = new House();
                //h.Draw(x, y);
                work = "Drawing a house";
            }
            else if( currentselect=="water")
            {
                //Water w = new Water();
                //w.Draw(x, y);
                work = "Drawing water";
            }
            else
            {
                MessageBox.Show("Select an item first! ");
            }

        }
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
            s.save();
        }
    }
}