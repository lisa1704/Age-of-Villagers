using System.Drawing;

namespace Age_of_Villagers
{
    internal class Nationfactory : INationFactory
    {
        INation nation;
        public INation GetNation(string nation_name)
        {
            Point location=new Point();
            if(nation_name=="Bangledeshi Farmer")
                return new Bangladesh(P: location);
            return nation;
        }

    }
}
