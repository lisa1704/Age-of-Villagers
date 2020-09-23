package Nations;

import House.ArabBedouinHouse;
import House.IHouse;
import Terrain.ArabBedouinTerrain;
import Terrain.ITerrain;
import Tree.ArabBedouinTree;
import Tree.ITree;
import WaterSource.ArabBedouinWaterSource;
import WaterSource.IWaterSource;

public class ArabBedouin implements INation {
    @Override
    public ITerrain getTerrain() {
        return new ArabBedouinTerrain();
    }

    @Override
    public ITree getTree() {
        return new ArabBedouinTree();
    }

    @Override
    public IHouse getHouse() {
        return new ArabBedouinHouse();
    }

    @Override
    public IWaterSource getWaterSource() {
        return new ArabBedouinWaterSource();
    }
}
