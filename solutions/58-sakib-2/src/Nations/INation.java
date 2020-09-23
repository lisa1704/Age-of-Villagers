package Nations;

import House.IHouse;
import Terrain.ITerrain;
import Tree.ITree;
import WaterSource.IWaterSource;

public interface INation {
    ITerrain getTerrain();
    ITree getTree();
    IHouse getHouse();
    IWaterSource getWaterSource();
}
