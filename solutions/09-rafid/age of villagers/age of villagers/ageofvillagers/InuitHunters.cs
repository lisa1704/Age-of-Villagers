using System;

public class InuitHunters : Nation
{
    private int waterX = 24, waterY = 16;
    public Ishape draw_tree(int x, int y)
    {
        
        return NotSupportedException;
    }

    public IShape draw_house(int x, int y)
    {
        house = new Inuithouse(x, y);
        return house;
    }

    public IShape draw_water(int waterX, int waterY)
    {
        
        return NotSupportedException;
    }

    public string backgroundColor()
    {
        return "pure white";
    }

}
