using System;

public class Nation
{
    public INation nationtype;
    public String getBackground()
    {
        return nationtype.backgroundcolor();
    }
}
