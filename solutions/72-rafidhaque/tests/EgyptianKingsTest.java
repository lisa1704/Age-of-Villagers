import javafx.embed.swing.JFXPanel;
import javafx.scene.Group;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;

public class EgyptianKingsTest {

    private EgyptianKings egyptianKings;
    private JFXPanel panel = new JFXPanel();
    private String nationName;

    @Before
    public void setUp() throws Exception {
        egyptianKings = new EgyptianKings(new Group());
        nationName = "Egyptian Kings";
    }

    @Test
    public void getNationName() {
        assertEquals(nationName, egyptianKings.getNationName());
    }

    @Test
    public void getHouse() {
        assertEquals("EgyptianKingsHouse", egyptianKings.getHouse().getClass().getSimpleName());
    }

    @Test
    public void getTree() {
        assertEquals("EgyptianKingsTree", egyptianKings.getTree().getClass().getSimpleName());
    }

    @Test
    public void getWater() {
        assertEquals("EgyptianKingsWater", egyptianKings.getWater().getClass().getSimpleName());
    }
}