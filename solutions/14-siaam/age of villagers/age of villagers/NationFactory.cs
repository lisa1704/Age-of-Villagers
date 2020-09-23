﻿namespace age_of_villagers
{
    public class NationFactory
    {
        public INation GetNation(string nation_name)
        {
            if (nation_name == "Bangladeshi Farmers")
            {
                return new Bangladeshifarmer();
            }
            else if (nation_name == "Arab Beduin")
            {
                return new ArabBeduin();
            }
            else if (nation_name == "Egyptian king")
            {
                return new Egyptianking();
            }
            else if (nation_name == "Inuit Hunter")
            {
                return new Inuithunter();
            }
            else
            {
                return new Null_Nation();
            }
        }
    }
}
