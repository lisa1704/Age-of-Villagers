﻿namespace AgeOfVillagers
{
    internal class Nation_Factory
    {
        public static Shape Get_Nation(string Nation_Name)
        {
            if (Nation_Name == "Bangladeshi_Farmer")
            {
                return new Bangladeshi_Factory();
            }

            return null;
        }
    }
}