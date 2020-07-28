package Tests;

import Project.Ghew;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.assertEquals;

public class testModule1 {

    @Test
    protected void BarkTest_1()
    {
        Ghew dog = new Ghew();
        String call = dog.Bark(1);
        assertEquals("Bhew", call);
    }

    @Test
    protected void BarkTest_2()
    {
        Ghew Animal = new Ghew();
        String call = Animal.Bark(2);
        assertEquals("Halum", call);
    }
}
