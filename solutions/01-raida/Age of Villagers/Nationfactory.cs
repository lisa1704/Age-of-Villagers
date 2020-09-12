using System.Drawing;

namespace Age_of_Villagers
{
    internal class Nationfactory : INationFactory
    {
        INation nation;
        public INation GetNation(string nation_name)
        {
            if(nation_name=="Bangledeshi Farmer")
                return new Bangladesh();
            return nation;
        }

    }
}
