namespace AgeOfVillagers
{
    internal class Nation_Factory
    {
        public static Shape Get_Nation(string Nation_Name)
        {
            if (Nation_Name == "Bangladeshi_Farmer")
            {
                return new Bangladeshi_Factory();
            }
            else if (Nation_Name == "Arab_Bedouin")
            {
                return new Arab_Factory();
            }
            else if (Nation_Name == "Egyptian_Kings")
            {
                return new Egyptian_Factory();
            }
            else if (Nation_Name == "Inuit_Hunters")
            {
                return new Inuit_Factory();
            }

            return null;
        }
    }
}