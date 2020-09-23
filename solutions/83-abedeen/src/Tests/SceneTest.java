package Tests;

import Project.Utilities.AssetInfo;
import Project.Utilities.SceneSate;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class SceneTest {
    @Test
    protected void scene_Name(){
        SceneSate sceneSate = new SceneSate("My Village");
        String expected = "My Village";
        Assertions.assertEquals(expected,sceneSate.Village_name);
    }

    @Test
    protected void scene_Content(){
        SceneSate Test_sceneSate = new SceneSate("My Village");

        SceneSate Expected_sceneSate = new SceneSate("My Village");

        AssetInfo AI = new AssetInfo("tree", 10, 50);
        Expected_sceneSate.assetList.add(AI);

        Test_sceneSate.add_asset_to_list("tree", 10, 50);

        Assertions.assertEquals(Test_sceneSate.assetList,Test_sceneSate.assetList);
    }
}
