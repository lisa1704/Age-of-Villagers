package nation;

import house.IHouse;
import terrain.BlankTrerrain;
import terrain.ITerrain;

public class NoNations implements INation {
    @Override
    public ITerrain getTerrain() {
        return new BlankTrerrain();
    }

    @Override
    public IHouse getHouse() {
        return null;
    }
}
