package nation;

import house.IHouse;
import terrain.EgyptianKingsTerrain;
import terrain.ITerrain;

public class EgyptianKings implements INation {
    @Override
    public ITerrain getTerrain() {
        return new EgyptianKingsTerrain();
    }

    @Override
    public IHouse getHouse() {
        return null;
    }
}
