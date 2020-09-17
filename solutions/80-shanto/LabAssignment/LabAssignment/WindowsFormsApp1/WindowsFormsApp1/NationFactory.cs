using System;


namespace WindowsFormsApp1
{
    class NationFactory
    {
        public INation GetNation(string NationType)
        {
            if (NationType == "BangladeshiFarmers")
            {
                return new BangladeshiFarmers();
            }
            else if (NationType == "ArabBedouin")
            {
                return new ArabBedouin();
            }
            else if (NationType == "EgyptianKing")
            {
                return new EgyptianKing();
            }
            else if (NationType == "InuitHunters")
            {
                return new InuitHunters();
            }
            throw new Exception();

        }
    }
}
