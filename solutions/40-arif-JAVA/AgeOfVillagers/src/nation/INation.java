package nation;

import house.IHouse;
import terrain.ITerrain;
import tree.ITree;
import water.IWater;

public interface INation {
    ITerrain getTerrain();
    IHouse getHouse();
    ITree getTree();
    IWater getWater();
}
