using System;

public class Nation : INation
{
	INation nation;
	public INation getNation(string nationName)
    {
        if (nationName == "Bangladeshifarmer")
            nation = new Bangladeshi_farmer();
        else if (nationName == "Arab_Bedouin")
            nation = new ArabBedouin();
        else if (nationName == "Egyptians_Kings")
            nation = new EgyptianKings();
        return nation;
    }
}
