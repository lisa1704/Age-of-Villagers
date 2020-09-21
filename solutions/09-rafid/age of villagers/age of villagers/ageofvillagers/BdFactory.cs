using System;

public class BdFactory : Shape
{
    IShape GetItem(string itemType)
    {
        if (itemType == "tree")
            return new Bdtree();
        else if (itemType == "house")
            return new Bdhouse();
        else if (itemType == "water")
            return new Bdwater();
        else
            return new NotSupportedException();
    }
}
