namespace ageOfVillagers
{
    internal class Tree: Village
    {
        int Xaxis = 16;
        int Yaxis = 24;
        public string Draw(int x, int y)
        {
            return "Drwaing a tree on (" + x + "," + y + ").";
        }
    }
}