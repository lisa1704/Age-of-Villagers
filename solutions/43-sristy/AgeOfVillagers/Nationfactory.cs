using System;
using System.Drawing;

namespace Age_of_villagers
{
    public class Nationfactory
    {
        public INation GetNation(string type)
        {
            if (type == "Bangladeshi Farmers")
            {
                return new Bangladeshi();
            }
            else if (type == "Egyptian Kings")
            {
                return new Egyptian();
            }
            else if (type == "Arab Beduin")
            {
                return new Arab();
            }
            else if (type == "Inuit Hunters")
            {
                return new Inuit();
            }
            else
            {
                return new NullNation();
            }
        }

    }
}
