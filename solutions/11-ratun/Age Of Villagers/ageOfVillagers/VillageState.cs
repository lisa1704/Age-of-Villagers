using System;

interface Istate
{
	string GetState();
}
public class VillageState : Istate
{
    string villagename;
    public void SetState(string villagename)
    {
        this.villagename = villagename;
    }
    public string GetState()
    {
        //return villagename.state();
        return "Giving State of " + villagename+". ";
    }
}
