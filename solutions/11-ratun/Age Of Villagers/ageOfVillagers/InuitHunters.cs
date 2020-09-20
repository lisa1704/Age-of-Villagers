using System;

public class InuitHunters : Nation
{
    public IShape draw_tree()
    {
        return NotSupportedException;
    }
    public IShape draw_house(int x, int y)
    {
        house = new Inuithouse(x, y);
        return house;
        //return "Drawing a tree. ";
    }
    public IShape draw_water()
    {
        return NotSupportedException;
    }
    public string backgroundColor()
    {
        return "pure white";
    }
}
