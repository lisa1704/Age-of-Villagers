namespace AgeofVillagers
{
    public class FactoryPattern
    {
        public INation GetNation(string type)
        {
            if (type == "BangladeshiFarmers")
            {
                return new BangladeshiFarmers();
            }
            else if (type == "EgyptianKings")
            {
                return new EgyptianKings();
            }

            else if (type == "ArabBedouin")
            {
                return new ArabBedouin();
            }

            else if (type == "InuitHunters")
            {
                return new InuitHunters();
            }
            else
            {
                return new NullNation();
            }
            
        }
    }
}
