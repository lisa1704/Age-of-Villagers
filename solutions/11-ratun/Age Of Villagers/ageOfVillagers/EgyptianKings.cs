using System;

public class EgyptianKings : Nation
{
    private int waterX = 12, waterY = 12;
    public IShape draw_tree(int x, int y)
    {
        tree = new Egypttree(x, y);
        return tree;
        //return "Drawing a tree. ";
    }
    public IShape draw_house(int x, int y)
    {
        house = new Egypthouse(x, y);
        return house;
        //return "Drawing a tree. ";
    }
    public IShape draw_water(int waterX, int waterY)
    {
        water = new Egyptwater(waterX, waterY);
        return water;
        //return "Drawing a tree. ";
    }
    public string backgroundColor()
    {
        return "plain yellow colour";
    }
}
