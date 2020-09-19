using System;

interface Istate
{
	public string getState();
}
public class VillageState : Istate
{
    string villagename;
    public string getState()
    {
        //return villagename.state();
        return "Giving State of " + villagename+". ";
    }
}
