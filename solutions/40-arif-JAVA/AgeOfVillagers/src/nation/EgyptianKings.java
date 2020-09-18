package nation;

import house.EgyptKingHouse;
import house.IHouse;
import terrain.EgyptianKingsTerrain;
import terrain.ITerrain;
import tree.EgyptTree;
import tree.ITree;
import water.EgyptWater;
import water.IWater;

public class EgyptianKings implements INation {
    @Override
    public ITerrain getTerrain() {
        return new EgyptianKingsTerrain();
    }

    @Override
    public IHouse getHouse() {
        return new EgyptKingHouse();
    }

    @Override
    public ITree getTree() {
        return new EgyptTree();
    }

    @Override
    public IWater getWater() {
        return new EgyptWater();
    }
}
