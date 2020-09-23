package sample;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

class TestClass {
    @Test
    void assertTest(){
        Assertions.assertEquals(2,2);
    }
    @Test
    void fileOpenTest(){
        Controller controller=new Controller();
        Assertions.assertEquals("village2",controller.loadVillage());
    }
}
