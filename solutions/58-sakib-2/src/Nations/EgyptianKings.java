package Nations;

import House.EgyptianKingsHouse;
import House.IHouse;
import Terrain.EgyptianKingsTerrain;
import Terrain.ITerrain;
import Tree.EgyptianKingsTree;
import Tree.ITree;
import WaterSource.EgyptianKingsWaterSource;
import WaterSource.IWaterSource;

public class EgyptianKings implements INation {
    @Override
    public ITerrain getTerrain() {
        return new EgyptianKingsTerrain();
    }

    @Override
    public ITree getTree() {
        return new EgyptianKingsTree();
    }

    @Override
    public IHouse getHouse() {
        return new EgyptianKingsHouse();
    }

    @Override
    public IWaterSource getWaterSource() {
        return new EgyptianKingsWaterSource();
    }
}
