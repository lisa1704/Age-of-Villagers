import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;

public class StateOfComponentTest {

    StateOfComponent stateOfComponent;
    double x = 30, y = 40;
    IDrawComponent drawComponent;

    @Before
    public void setUp() throws Exception {
        drawComponent = new ArabBedouinHouse();
        stateOfComponent = new StateOfComponent(x, y, drawComponent);
        stateOfComponent.setX(x);
        stateOfComponent.setY(y);
        stateOfComponent.className = drawComponent.getClass().getSimpleName();
    }

    @Test
    public void getX() {
        int expected = 30;
        int actual = (int) stateOfComponent.getX();
        assertEquals(expected, actual);
    }

    @Test
    public void getY() {
        int expected = 40;
        int actual = (int) stateOfComponent.getY();
        assertEquals(expected, actual);
    }

    @Test
    public void getX2() {
        int expected = 40;
        int actual = (int) stateOfComponent.getX();
        assertNotEquals(expected, actual);
    }

    @Test
    public void getY2() {
        int expected = 30;
        int actual = (int) stateOfComponent.getY();
        assertNotEquals(expected, actual);
    }

    @Test
    public void testToString() {
        String expected = "StateOfComponent{" +
                "x=" + 30.0 +
                ", y=" + 40.0 +
                ", drawComponent=" + drawComponent +
                ", className='ArabBedouinHouse'}";
        String actual = stateOfComponent.toString();
        assertEquals(actual, expected);
    }

    @Test
    public void testToString2() {
        String expected = "StateOfComponent{" +
                "x=" + 30.0 +
                ", y=" + 40.0 +
                ", drawComponent=" + drawComponent +
                ", className='BangladeshiFarmersHouse'}";
        String actual = stateOfComponent.toString();
        assertNotEquals(actual, expected);
    }
}