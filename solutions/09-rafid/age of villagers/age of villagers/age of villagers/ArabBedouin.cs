using System;

public class ArabBedouin : Nation
{
    
    public Ishape draw_tree(int x, int y)
    {
        tree = new Arabtree(x, y);
        return tree;
    }

    public IShape draw_house(int x, int y)
    {
        house = new Arabhouse(x, y);
        return house;
    }
    public IShape draw_water()
    {
       
        return unavailable;
    }

    public string backgroundColor()
    {
        return "yellowish";
    }


}
