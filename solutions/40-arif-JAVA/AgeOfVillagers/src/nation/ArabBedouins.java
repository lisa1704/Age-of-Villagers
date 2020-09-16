package nation;

import terrain.ArabBedouinTerrain;
import terrain.ITerrain;

public class ArabBedouins implements INation {
    @Override
    public ITerrain getTerrain() {
        return new ArabBedouinTerrain();
    }
}
