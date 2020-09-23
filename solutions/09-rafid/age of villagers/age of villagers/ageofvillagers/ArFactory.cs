using System;

public class ArFactory : Shape
{
    IShape GetItem(string itemType)
    {
        if (Item_Type == "Tree")
            return new Arab_Tree();
        else if (Item_Type == "House")
            return new Arab_House();
        else
            return new NotSupportedException();
    }
}
