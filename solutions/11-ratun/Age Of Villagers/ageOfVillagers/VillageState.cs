﻿using System;

interface Istate
{
	string GetState();
}
public class VillageState : Istate
{
    string villagename, state;
    public void SetState(string villagename)
    {
        this.villagename = villagename;
    }
    public void UpdateState(string element, int x, int y)
    {
        state += "village has a " + element + "on (" + x + "," + y + "). ";
    }
    public string GetState()
    {
        //return villagename.state();
        return "Giving State of " + villagename+"= "+state;
    }
}