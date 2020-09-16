package nation;

import house.IHouse;
import terrain.BDFarmerTerrain;
import terrain.ITerrain;

public class BDFarmers implements INation {
    @Override
    public ITerrain getTerrain() {
        return new BDFarmerTerrain();
    }

    @Override
    public IHouse getHouse() {
        return null;
    }
}
