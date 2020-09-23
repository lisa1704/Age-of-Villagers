import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;

public class ChoiceWindowTest {

    ChoiceWindow choiceWindow;

    @Before
    public void setUp() throws Exception {
        choiceWindow = new ChoiceWindow();
    }

    @Test
    public void removeLastChars1() {
        String actual = choiceWindow.removeLastChars("tundra.aov", 4);
        String expected = "tundra";
        assertEquals(actual, expected);
    }
    @Test
    public void removeLastChars2() {
        String actual = choiceWindow.removeLastChars("tundra.aov", 4);
        String expected = "tundra.aov";
        assertNotEquals(actual, expected);
    }
}