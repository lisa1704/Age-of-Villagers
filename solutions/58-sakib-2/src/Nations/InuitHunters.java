package Nations;

import House.IHouse;
import House.InuitHuntersHouse;
import Terrain.ITerrain;
import Terrain.InuitHuntersTerrain;
import Tree.ITree;
import Tree.InuitHuntersTree;
import WaterSource.IWaterSource;
import WaterSource.InuitHuntersWaterSource;

public class InuitHunters implements INation {
    @Override
    public ITerrain getTerrain() {
        return new InuitHuntersTerrain();
    }

    @Override
    public ITree getTree() {
        return new InuitHuntersTree();
    }

    @Override
    public IHouse getHouse() {
        return new InuitHuntersHouse();
    }

    @Override
    public IWaterSource getWaterSource() {
        return new InuitHuntersWaterSource();
    }
}
