package nation;

import house.IHouse;
import house.InuitHunterHouse;
import terrain.ITerrain;
import terrain.InuitHuntrsTerrain;
import tree.ITree;
import tree.InuitTree;
import water.IWater;
import water.InuitWater;

public class InuitHunters implements INation {
    @Override
    public ITerrain getTerrain() {
        return new InuitHuntrsTerrain();
    }

    @Override
    public IHouse getHouse() {
        return new InuitHunterHouse();
    }

    @Override
    public ITree getTree() {
        return new InuitTree();
    }

    @Override
    public IWater getWater() {
        return new InuitWater();
    }
}
