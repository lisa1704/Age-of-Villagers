package nation;

import house.BDHouse;
import house.IHouse;
import terrain.BDFarmerTerrain;
import terrain.ITerrain;
import tree.BDTree;
import tree.ITree;
import water.BDWater;
import water.IWater;

public class BDFarmers implements INation {
    @Override
    public ITerrain getTerrain() {
        return new BDFarmerTerrain();
    }

    @Override
    public IHouse getHouse() {
        return new BDHouse();
    }

    @Override
    public ITree getTree() {
        return new BDTree();
    }

    @Override
    public IWater getWater() {
        return new BDWater();
    }
}
