namespace ageOfVillagers
{
    internal class House : Village
    {
        int Xaxis = 16;
        int Yaxis = 24;
        public void Draw(int x, int y)
        {
            //return "Drwaing a house on (" + x + "," + y + ").";
            VillageState vs = new VillageState();
            vs.UpdateState("House", x, y);
        }
    }
}