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

    @Test
    protected void Arabian_WaterBody_Factory_Test()
    {
        Nation Arab = new Nation("Arab Bedouins");
        IWaterBody water_body = new Null_Water_Body();
        Assertions.assertEquals(water_body.getClass(), Arab.water_body.getClass());
    }

    @Test
    protected void Inuit_WaterBody_Factory_Test()
    {
        Nation Inuit = new Nation("Inuit Hunters");
        IWaterBody water_body = new Null_Water_Body();
        Assertions.assertEquals(water_body.getClass(), Inuit.water_body.getClass());
    }

}
