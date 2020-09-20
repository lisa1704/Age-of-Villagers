using System;

public class ArabBedouin : Nation
{
    public IShape draw_tree(int x, int y)
    {
        tree = new Arabtree(x, y);
        return tree;
        //return "Drawing a tree. ";
    }
    public IShape draw_house(int x, int y)
    {
        house = new Arabhouse(x, y);
        return house;
        //return "Drawing a tree. ";
    }
    public IShape draw_water()
    {
        return NotSupportedException;
    }
    public string backgroundColor()
    {
        return "yellowish";
    }
}
