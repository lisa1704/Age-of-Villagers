namespace ageOfVillagers
{
    internal class Water: Village
    {
        //int Xaxis = nationName.waterXaxis();
        //int Yaxis = nationName.waterYaxis();
        public void Draw(int x, int y)
        {
            //return "Drwaing a water on (" + x + "," + y + ").";
            VillageState vs = new VillageState();
            vs.UpdateState("Water", x, y);
        }
    }
}