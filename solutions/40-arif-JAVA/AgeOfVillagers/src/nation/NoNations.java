package nation;

import house.BlankHouse;
import house.IHouse;
import terrain.NoTrerrain;
import terrain.ITerrain;
import tree.ITree;
import tree.NoTree;
import water.IWater;
import water.NoWater;

public class NoNations implements INation {
    @Override
    public ITerrain getTerrain() {
        return new NoTrerrain();
    }

    @Override
    public IHouse getHouse() {
        return new BlankHouse();
    }

    @Override
    public ITree getTree() {
        return new NoTree();
    }

    @Override
    public IWater getWater() {
        return new NoWater();
    }
}
