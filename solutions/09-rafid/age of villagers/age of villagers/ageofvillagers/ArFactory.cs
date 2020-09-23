using System;

public class ArFactory : Shape
{
    IShape GetItem(string itemType)
    {
        if (Item_Type == "Tree")
            return new Arabtree();
        else if (Item_Type == "House")
            return new Arabhouse();
        else
            return new NotSupportedException();
    }
}
