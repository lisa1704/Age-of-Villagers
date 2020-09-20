package sample;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class BangladeshiFarmersTreeTest {
    BangladeshiFarmersTree t= new BangladeshiFarmersTree();
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