package Tests;

import Project.Utilities.Nation;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class TerrainColorTest {
    @Test
    protected void bangladeshi_Terrain_Test(){
        Nation bangladesh = new Nation("Bangladeshi Farmers");
        String ExpectedColor = "#93cf88";
        Assertions.assertEquals(ExpectedColor, bangladesh.GetTerrainColor());

    }

    @Test
    protected void Arabian_Terrain_Test(){
        Nation Arab = new Nation("Arab Bedouins");
        String ExpectedColor = "#fffde3";
        Assertions.assertEquals(ExpectedColor, Arab.GetTerrainColor());
    }

    @Test
    protected void Egyptian_Terrain_Test(){
        Nation Egyptian = new Nation("Egyptian Kings");
        String ExpectedColor = "#fcd556";
        Assertions.assertEquals(ExpectedColor, Egyptian.GetTerrainColor());

    }

    @Test
    protected void Inuit_Terrain_Test(){
        Nation Inuit = new Nation("Inuit Hunters");
        String ExpectedColor = "WHITE";
        Assertions.assertEquals(ExpectedColor, Inuit.GetTerrainColor());

    }

    @Test
    protected void Random_Terrain_Test(){
        Nation any = new Nation("A random nation");
        String ExpectedColor = "WHITE";
        Assertions.assertEquals(ExpectedColor, any.GetTerrainColor());

    }
}
