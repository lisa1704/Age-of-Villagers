using System;

public class Egyptians_kings : Nation
{
    private int waterX = 12, waterY = 12;
    public Ishape draw_tree(int x, int y)
    {
        tree = new Egypttree(x, y);
        return tree;
    }

    public IShape draw_house(int x, int y)
    {
        house = new Egypthouse(x, y);
        return house;
    }

    public IShape draw_water(int waterX, int waterY)
    {
        water = new Egyptwater(waterX, waterY);
        return water;
    }

    public string backgroundColor()
    {
        return "plain green colour";
    }

}
