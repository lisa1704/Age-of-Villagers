namespace ageOfVillagers
{
    internal class House : Village
    {
        int Xaxis = 16;
        int Yaxis = 24;
        public string Draw(int x, int y)
        {
            return "Drwaing a house on (" + x + "," + y + ").";
        }
    }
}