using System;

public class Bangladeshi_farmer : Nation
{
    private int waterX = 24, waterY = 16;
    public Ishape draw_tree(int x, int y)
    {
        tree = new Bdtree(x, y);
        return tree;
    }

    public IShape draw_house(int x, int y)
    {
        house = new Bdhouse(x, y);
        return house;
    }

    public IShape draw_water(int waterX, int waterY)
    {
        water = new Bdwater(waterX, waterY);
        return water;
    }

    public string backgroundColor()
    {
        return "plain green colour";
    }



}
