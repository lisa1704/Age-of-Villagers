package nation;

import terrain.ITerrain;
import terrain.InuitHuntrsTerrain;

public class InuitHunters implements INation {
    @Override
    public ITerrain getTerrain() {
        return new InuitHuntrsTerrain();
    }
}
