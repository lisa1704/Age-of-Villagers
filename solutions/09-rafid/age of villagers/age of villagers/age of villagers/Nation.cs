using System;

public class Nation : INation
{
	INation nation;
	public INation getNation(string nationName)
    {
        if (nationName == "Bangladeshifarmer")
            nation = new Bangladeshi_farmer();
        return nation;
    }
}
