package Tests;

import Project.Utilities.Nation;
import Project.Utilities.NationItems.*;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class WaterBodyFactory {
    @Test
    protected void Bangladeshi_WaterBody_Factory_Test()
    {
        Nation bangladesh = new Nation("Bangladeshi Farmers");
        IWaterBody water_body = new Bangladeshi_Waterbody();
        Assertions.assertEquals(water_body.getClass(), bangladesh.water_body.getClass());
    }

    @Test
    protected void Egyptian_WaterBody_Factory_Test()
    {
        Nation Egyptian = new Nation("Egyptian Kings");
        IWaterBody water_body = new Egyptian_Kings_Waterbody();
        Assertions.assertEquals(water_body.getClass(), Egyptian.water_body.getClass());
    }

}
