package nation;

import house.IHouse;
import terrain.ArabBedouinTerrain;
import terrain.ITerrain;

public class ArabBedouins implements INation {
    @Override
    public ITerrain getTerrain() {
        return new ArabBedouinTerrain();
    }

    @Override
    public IHouse getHouse() {
        return null;
    }
}
