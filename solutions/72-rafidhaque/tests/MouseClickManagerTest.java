import org.junit.Test;

import static org.junit.Assert.*;

public class MouseClickManagerTest {

    MouseClickManager mouseClickManager = new MouseClickManager();

    @Test
    public void mouseRestriction1() {
        boolean actual = mouseClickManager.mouseRestriction(100, 200);
        assertEquals(actual, true);
    }

    @Test
    public void mouseRestriction2() {
        boolean actual = mouseClickManager.mouseRestriction(1000, 200);
        assertNotEquals(actual, true);
    }
}