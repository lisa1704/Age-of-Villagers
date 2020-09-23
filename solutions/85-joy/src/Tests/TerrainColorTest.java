package Tests;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;
import project.Utilities.NationFactory;

public class TerrainColorTest {

    @Test
    void Bangladeshi_Farmers_Terrain_Test(){
        NationFactory nationFactory = new NationFactory("Bangladeshi Farmers");
        String actual = nationFactory.getTerrainColor("Bangladeshi Farmers");

        Assertions.assertEquals("#9DE0AD",actual);
    }

    @Test
    void Arab_Bedouin_Terrain_Test(){
        NationFactory nationFactory = new NationFactory("Arab Bedouin");
        String actual = nationFactory.getTerrainColor("Arab Bedouin");

        Assertions.assertEquals("#EDE574",actual);
    }

    @Test
    void Egyptian_Kings_Terrain_Test(){
        NationFactory nationFactory = new NationFactory("Egyptian Kings");
        String actual = nationFactory.getTerrainColor("Egyptian Kings");

        Assertions.assertEquals("#F9D423",actual);
    }

    @Test
    void Inuit_Hunters_Terrain_Test(){
        NationFactory nationFactory = new NationFactory("Inuit Hunters");
        String actual = nationFactory.getTerrainColor("Inuit Hunters");

        Assertions.assertEquals("WHITE",actual);
    }


}
