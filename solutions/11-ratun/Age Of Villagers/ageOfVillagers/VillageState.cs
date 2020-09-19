using System;

interface Istate
{
	public string getState();
}
public class VillageState : Istate
{
    string villagename;
	public string getState(string villagename)
    {
        //return villagename.state();
        return "Saving the village " + villagename;
    }
}
