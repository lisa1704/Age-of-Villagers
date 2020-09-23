package Nations;

import House.BangladeshiFarmersHouse;
import House.IHouse;
import Terrain.BangladeshiFarmersTerrain;
import Terrain.ITerrain;
import Tree.BangladeshiFarmersTree;
import Tree.ITree;
import WaterSource.BangladeshiFarmersWaterSource;
import WaterSource.IWaterSource;

public class BangladeshiFarmers implements INation{
    @Override
    public ITerrain getTerrain() {
        return new BangladeshiFarmersTerrain();
    }

    @Override
    public ITree getTree() {
        return new BangladeshiFarmersTree();
    }

    @Override
    public IHouse getHouse() {
        return new BangladeshiFarmersHouse();
    }

    @Override
    public IWaterSource getWaterSource() {
        return new BangladeshiFarmersWaterSource();
    }
}
