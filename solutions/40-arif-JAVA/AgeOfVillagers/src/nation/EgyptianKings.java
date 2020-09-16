package nation;

import terrain.EgyptianKingsTerrain;
import terrain.ITerrain;

public class EgyptianKings implements INation {
    @Override
    public ITerrain getTerrain() {
        return new EgyptianKingsTerrain();
    }
}
