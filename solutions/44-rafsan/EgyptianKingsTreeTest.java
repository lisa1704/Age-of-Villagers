package sample;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class EgyptianKingsTreeTest {

    EgyptianKingsTree t= new EgyptianKingsTree();

    @Test
    void canvasController() {
        assertEquals("CanvasController is working",t.canvasController());
    }

    @Test
    void releaseCanvas() {
        assertEquals("releaseCanvas is working",t.releaseCanvas());
    }

    @Test
    void getCanvas() {
        assertEquals("getCanvas is working",t.getCanvas());
    }
}