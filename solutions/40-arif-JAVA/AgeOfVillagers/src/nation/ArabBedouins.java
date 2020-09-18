package nation;

import house.ArabBedouinHouse;
import house.IHouse;
import terrain.ArabBedouinTerrain;
import terrain.ITerrain;
import tree.ArabTree;
import tree.ITree;
import water.ArabWater;
import water.IWater;

public class ArabBedouins implements INation {
    @Override
    public ITerrain getTerrain() {
        return new ArabBedouinTerrain();
    }

    @Override
    public IHouse getHouse() {
        return new ArabBedouinHouse();
    }

    @Override
    public ITree getTree() {
        return new ArabTree();
    }

    @Override
    public IWater getWater() {
        return new ArabWater();
    }
}
