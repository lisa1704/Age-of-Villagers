package nation;

import terrain.BlankTrerrain;
import terrain.ITerrain;

public class NoNations implements INation {
    @Override
    public ITerrain getTerrain() {
        return new BlankTrerrain();
    }
}
