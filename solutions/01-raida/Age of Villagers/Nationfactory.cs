using System.Drawing;

namespace Age_of_Villagers
{
    internal class Nationfactory : INationFactory
    {
        INation nation;
        public INation GetNation(string nation_name)
        {
            if (nation_name == "Bangladeshi Farmers")
                nation = new Bangladesh();
            else if (nation_name == "Arab Bedouin")
                nation = new Arab();
            return nation;
        }

    }
}
