import javafx.embed.swing.JFXPanel;
import javafx.scene.Group;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;

public class BangladeshiFarmersTest {
    private BangladeshiFarmers bangladeshiFarmers;
    private JFXPanel panel = new JFXPanel();
    private String nationName;

    @Before
    public void setUp() throws Exception {
        bangladeshiFarmers = new BangladeshiFarmers(new Group());
        nationName = "BangladeshiFarmers";
    }

    @Test
    public void getNationName() {
        assertEquals(nationName, bangladeshiFarmers.getNationName());
    }

    @Test
    public void getHouse() {
        assertEquals("BangladeshiFarmersHouse", bangladeshiFarmers.getHouse().getClass().getSimpleName());
    }

    @Test
    public void getTree() {
        assertEquals("BangladeshiFarmersTree", bangladeshiFarmers.getTree().getClass().getSimpleName());
    }

    @Test
    public void getWater() {
        assertEquals("BangladeshiFarmersWater", bangladeshiFarmers.getWater().getClass().getSimpleName());
    }
}