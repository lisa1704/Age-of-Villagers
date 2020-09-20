using System;

public class BangladeshiFarmer : Nation
{
    private int waterX=24, waterY=16;
    public IShape draw_tree(int x, int y)
    {
        tree = new Bdtree(x,y);
        return tree;
        //return "Drawing a tree. ";
    }
    public IShape draw_house(int x, int y)
    {
        house = new Bdhouse(x, y);
        return house;
        //return "Drawing a tree. ";
    }
    public IShape draw_water(int waterX, int waterY)
    {
        water = new Bdwater(x, y);
        return water;
        //return "Drawing a tree. ";
    }
    public string backgroundColor()
    {
        return "plain green colour";
    }
}
