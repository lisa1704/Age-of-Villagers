namespace ageOfVillagers
{
    internal abstract class House : Village
    {
        //int Xaxis = 16;
        //int Yaxis = 16;
        public abstract void CreateHouse(int x, int y);
        public void Draw(int x, int y)
        {
            //return "Drwaing a house on (" + x + "," + y + ").";
            VillageState vs = new VillageState();
            vs.UpdateState("House", x, y);
        }
    }
}