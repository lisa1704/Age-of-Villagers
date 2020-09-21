namespace ageOfVillagers
{
    internal abstract class Water
    {
        //int Xaxis = nationName.waterXaxis();
        //int Yaxis = nationName.waterYaxis();
        public abstract void CreateWater(int x, int y);
        public void Draw(int x, int y)
        {
            //return "Drwaing a water on (" + x + "," + y + ").";
            VillageState vs = new VillageState();
            vs.UpdateState("Water", x, y);
        }
    }
}