package Tests;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;
import project.Utilities.Factories.HouseFactory;
import project.Utilities.Factories.IAssetFactory;
import project.Utilities.Factories.TreeFactory;
import project.Utilities.Factories.WaterSourceFactory;
import project.Utilities.NationItems.*;


public class AssetTests {

    @Test
    void Arab_Bedouin_House_Test(){
        IAssetFactory houseFactory = new HouseFactory();
        IHouse house = (IHouse) houseFactory.createAsset("Arab Bedouin");

        Assertions.assertEquals(house.getClass(),new Arab_Bedouin_House().getClass());
    }

    @Test
    void Arab_Bedouin_Tree_Test(){
        IAssetFactory treeFactory = new TreeFactory();
        ITree tree = (ITree) treeFactory.createAsset("Arab Bedouin");

        Assertions.assertEquals(new Arab_Bedouin_Tree().getClass(),tree.getClass());
    }

    @Test
    void Arab_Bedouin_WaterSource_Test(){
        IAssetFactory WaterSourceFactory = new WaterSourceFactory();
        IWaterSource waterSource = (IWaterSource) WaterSourceFactory.createAsset("Arab Bedouin");

        Assertions.assertEquals(waterSource.getClass(),new Null_WaterSource().getClass());
    }

    @Test
    void Bangladeshi_Farmers_House_Test(){
        IAssetFactory houseFactory = new HouseFactory();
        IHouse house = (IHouse) houseFactory.createAsset("Bangladeshi Farmers");

        Assertions.assertEquals(new Bangladeshi_Farmers_House().getClass(),house.getClass());
    }

    @Test
    void Bangladeshi_Farmers_Tree_Test(){
        IAssetFactory treeFactory = new TreeFactory();
        ITree tree = (ITree) treeFactory.createAsset("Bangladeshi Farmers");

        Assertions.assertEquals(new Bangladeshi_Farmers_Tree().getClass(),tree.getClass());
    }

    @Test
    void Bangladeshi_Farmers_WaterSource_Test(){
        IAssetFactory waterSourceFactory = new WaterSourceFactory();
        IWaterSource waterSource = (IWaterSource) waterSourceFactory.createAsset("Bangladeshi Farmers");

        Assertions.assertEquals(new Bangladeshi_Farmers_WaterSource().getClass(),waterSource.getClass());
    }

    @Test
    void Egyptian_Kings_House_Test(){
        IAssetFactory houseFactory= new HouseFactory();
        IHouse house = (IHouse) houseFactory.createAsset("Egyptian Kings");

        Assertions.assertEquals(new Egyptian_Kings_House().getClass(),house.getClass());
    }

    @Test
    void Egyptian_Kings_Tree_Test(){
        IAssetFactory treeFactory= new TreeFactory();
        ITree tree = (ITree) treeFactory.createAsset("Egyptian Kings");

        Assertions.assertEquals(new Egyptian_kings_Tree().getClass(),tree.getClass());
    }

    @Test
    void Egyptian_Kings_WaterSource_Test(){
        IAssetFactory waterSourceFactory= new WaterSourceFactory();
        IWaterSource waterSource = (IWaterSource) waterSourceFactory.createAsset("Egyptian Kings");

        Assertions.assertEquals(new Egyptian_Kings_WaterSource().getClass(),waterSource.getClass());
    }

    @Test
    void Inuit_Hunters_House_Test(){
        IAssetFactory houseFactory= new HouseFactory();
        IHouse house = (IHouse) houseFactory.createAsset("Inuit Hunters");

        Assertions.assertEquals(new Iuit_Hunters_House().getClass(),house.getClass());
    }

    @Test
    void Inuit_Hunters_Tree_Test(){
        IAssetFactory treeFactory= new TreeFactory();
        ITree tree = (ITree) treeFactory.createAsset("Inuit Hunters");

        Assertions.assertEquals(new Null_Tree().getClass(),tree.getClass());
    }

    @Test
    void Inuit_Hunters_WaterSource_Test(){
        IAssetFactory waterSourceFactory= new WaterSourceFactory();
        IWaterSource waterSource = (IWaterSource) waterSourceFactory.createAsset("Inuit Hunters");

        Assertions.assertEquals(new Null_WaterSource(),waterSource.getClass());
    }



}
