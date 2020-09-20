using System;

public class Nation : INation
{
    INation nation;
    public INation getNation(string nationName)
    {
        if (nationName == "Bangladeshi_Farmer")
            nation = new BangladeshiFarmer();
        else if (nationName == "Arab_Bedouin")
            nation = new ArabBedouin();
        else if (nationName == "Egyptian_Kings")
            nation = new EgyptianKings();
        else if (nationName == "Inuit_Hunters")
            nation = new InuitHunters();
        return nation;
    }
}
