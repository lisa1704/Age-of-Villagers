package nation;

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
}
