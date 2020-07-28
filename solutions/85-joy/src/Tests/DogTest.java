package Tests;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;
import project.Dog;

public class DogTest {

    @Test
    public void BarkTest1(){
        Dog dog = new Dog(1);
        String result = dog.bark();
        Assertions.assertEquals("GHEU!",result);
    }
    
    @Test
    public void BarkTestDefault(){
        Dog dog = new Dog(85);
        String result = dog.bark();
        Assertions.assertEquals("VOU!",result);
    }
}
