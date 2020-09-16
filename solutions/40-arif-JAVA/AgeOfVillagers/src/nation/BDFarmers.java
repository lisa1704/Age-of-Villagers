package nation;

import terrain.BDFarmerTerrain;
import terrain.ITerrain;

public class BDFarmers implements INation {
    @Override
    public ITerrain getTerrain() {
        return new BDFarmerTerrain();
    }
}
