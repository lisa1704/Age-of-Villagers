using System;

public class EgFactory
{
    IShape GetItem(string itemType)
    {
        if (Item_Type == "Tree")
            return new Egypttree();
        else if (Item_Type == "House")
            return new Egypthouse();
        else if (Item_Type == "Water_Resource")
            return new Egyptwater();
        else
            throw new NotSupportedException();
    }
}
