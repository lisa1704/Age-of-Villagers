package nation;

import house.IHouse;
import terrain.ITerrain;
import tree.ITree;
import water.IWater;

public class NationManager {
    private INation nation;
    private NationFactory nationFactory;

    public NationManager(String nationType) {
        nationFactory = new NationFactory();
        nation = nationFactory.getNation(nationType);
    }

    public ITerrain getTerrain() {
        return nation.getTerrain();
    }

    public IHouse getHouse(){
        return nation.getHouse();
    }
    public ITree getTree(){
        return nation.getTree();
    }
    public IWater getWater(){
        return nation.getWater();
    }
}
