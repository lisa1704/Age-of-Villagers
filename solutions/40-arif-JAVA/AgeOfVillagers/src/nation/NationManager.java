package nation;

import house.IHouse;
import terrain.ITerrain;

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
}
