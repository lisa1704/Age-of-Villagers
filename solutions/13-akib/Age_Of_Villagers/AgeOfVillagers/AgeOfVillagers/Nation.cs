using System;

namespace AgeOfVillagers

public class Nation : I_Nation
{
	I_Nation nation;
	public I_Nation Get_Nation(string nation)
    {
        if (nation == "BD_Farmers")
            nation = new Bangladeshi_Farmer();

        else if (nation == "Arab_Beduin")
            nation = new Arab_Bedouin();

        else if (nation == "Egyptian_Kings")
            nation = new Egyptian_Kings();

        return nation;
    }
}
