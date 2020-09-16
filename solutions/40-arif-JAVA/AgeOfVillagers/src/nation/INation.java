package nation;

import house.IHouse;
import terrain.ITerrain;

public interface INation {
    ITerrain getTerrain();
    IHouse getHouse();
}
