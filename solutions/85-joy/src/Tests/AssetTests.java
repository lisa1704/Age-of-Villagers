package Tests;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;
import project.Utilities.Factories.HouseFactory;
import project.Utilities.Factories.IAssetFactory;
import project.Utilities.Factories.TreeFactory;
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
    
}
