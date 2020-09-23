package terrain;

import canvas.MyCanvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;

public class EgyptianKingsTerrain implements ITerrain {
    @Override
    public void draw() {

        MyCanvas myCanvas = MyCanvas.getInstance();
        GraphicsContext graphicsContext = myCanvas.getCanvas().getGraphicsContext2D();
        graphicsContext.setFill(Color.LIGHTYELLOW);
        graphicsContext.fillRect(0, 0, 525, 498);


    }
}
