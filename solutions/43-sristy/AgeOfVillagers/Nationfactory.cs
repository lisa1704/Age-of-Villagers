using System;

namespace Age_of_villagers
{
    public class Nationfactory
    {
        public INation GetNation(string type)
        {
            if (type == "Bangladeshi")
            {
                return new Bangladeshi();
            }
            else if (type == "Egyptian")
            {
                return new Egyptian();
            }
            else if (type == "Arab")
            {
                return new Arab();
            }
            else if (type=="Inuit")
            {
                return new Inuit();
            }
            throw new Exception();
        }
    }
}
