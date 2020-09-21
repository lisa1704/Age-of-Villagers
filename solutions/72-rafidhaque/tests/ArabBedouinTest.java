import javafx.embed.swing.JFXPanel;
import javafx.scene.Group;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;

public class ArabBedouinTest {

    private ArabBedouin arabBedouin;
    private JFXPanel panel = new JFXPanel();
    private String nationName;

    @Before
    public void setUp() throws Exception {
        arabBedouin = new ArabBedouin(new Group());
        nationName = "Arab Bedouin";
    }

    @Test
    public void getNationName() {
        assertEquals(nationName, arabBedouin.getNationName());
    }

    @Test
    public void getHouse() {
        assertEquals("ArabBedouinHouse", arabBedouin.getHouse().getClass().getSimpleName());
    }

    @Test
    public void getTree() {
        assertEquals("ArabBedouinTree", arabBedouin.getTree().getClass().getSimpleName());
    }

    @Test
    public void getWater() {
        assertEquals("NoWater", arabBedouin.getWater().getClass().getSimpleName());
    }
}