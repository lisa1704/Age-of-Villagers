using System;

public class Nation : INation
{
    INation nation;
    public INation getNation(string nationName)
    {
        if (nationName == "Bangladeshi_farmer")
            nation = new BangladeshiFarmer();
        return nation;
    }
}
