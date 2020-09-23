package Tests;

import Project.Controllers.VillageView_controller;
import Project.Utilities.Nation;
import Project.Utilities.NationItems.*;
import Project.Utilities.SceneSate;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class NationTest {
    Nation nation = new Nation("Bangladeshi Farmers");
    double x = 10;
    double y = 15;

    @Test
    protected void houseTest(){
        IHouse BDH = new Bangladeshi_House();
        Assertions.assertEquals(nation.drawHouse(x,y).toString(),BDH.drawAsset(x,y).toString());
    }

    @Test
    protected void TreeTest(){
        ITree BDT = new Bangladeshi_Tree();
        Assertions.assertEquals(nation.drawTree(x,y).toString(),BDT.drawAsset(x,y).toString());
    }

    @Test
    protected void WaterBodyTest(){
        IWaterBody BDWB = new Bangladeshi_Waterbody();
        Assertions.assertEquals(nation.drawWaterBody(x,y).toString(),BDWB.drawAsset(x,y).toString());
    }

    @Test
    protected void TerrainTest(){
        INationColor BDH = new BangladeshiFarmersTerrain();
        Assertions.assertEquals("#93cf88",nation.GetTerrainColor());
    }
}
