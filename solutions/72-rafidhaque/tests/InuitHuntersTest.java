import javafx.embed.swing.JFXPanel;
import javafx.scene.Group;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;

public class InuitHuntersTest {

    private InuitHunters inuitHunters;
    private JFXPanel panel = new JFXPanel();
    private String nationName;

    @Before
    public void setUp() throws Exception {
        inuitHunters = new InuitHunters(new Group());
        nationName = "Inuit Hunters";
    }

    @Test
    public void getNationName() {
        assertEquals(nationName, inuitHunters.getNationName());
    }

    @Test
    public void getHouse() {
        assertEquals("InuitHuntersHouse", inuitHunters.getHouse().getClass().getSimpleName());
    }

    @Test
    public void getTree() {
        assertEquals("NoTree", inuitHunters.getTree().getClass().getSimpleName());
    }

    @Test
    public void getWater() {
        assertEquals("NoWater", inuitHunters.getWater().getClass().getSimpleName());
    }
}