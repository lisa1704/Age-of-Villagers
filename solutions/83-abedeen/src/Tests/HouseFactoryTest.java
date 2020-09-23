package Tests;
import Project.Utilities.Nation;
import Project.Utilities.NationItems.*;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class HouseFactoryTest {
    @Test
    protected void Bangladeshi_House_Factory_Test()
    {
        Nation bangladesh = new Nation("Bangladeshi Farmers");
        IHouse house = new Bangladeshi_House();
        Assertions.assertEquals(house.getClass(), bangladesh.house.getClass());
    }

    @Test
    protected void Arabian_House_Factory_Test()
    {
        Nation Arab = new Nation("Arab Bedouins");
        IHouse house = new Arab_Bedouin_House();
        Assertions.assertEquals(house.getClass(), Arab.house.getClass());
    }

    @Test
    protected void Egyptian_House_Factory_Test()
    {
        Nation Egyptian = new Nation("Egyptian Kings");
        IHouse house = new Egyptian_Kings_House();
        Assertions.assertEquals(house.getClass(), Egyptian.house.getClass());
    }

    @Test
    protected void Inuit_House_Factory_Test()
    {
        Nation Inuit = new Nation("Inuit Hunters");
        IHouse house = new Inuit_Hunters_House();
        Assertions.assertEquals(house.getClass(), Inuit.house.getClass());
    }

    @Test
    protected void Null_House_Factory_Test()
    {
        Nation any = new Nation("A random nation");
        IHouse house = new Null_House();
        Assertions.assertEquals(house.getClass(), any.house.getClass());
    }
}
