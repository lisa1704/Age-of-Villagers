package terrain;

import canvas.CanvasSingleton;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;

public class BangladeshiFarmerTerrain implements ITerrain{
    @Override
    public void draw() {
        CanvasSingleton canvasSingleton = CanvasSingleton.getInstance();
        GraphicsContext graphicsContext = canvasSingleton.getCanvas().getGraphicsContext2D();
        graphicsContext.setFill(Color.web("#d9f5a6"));
        graphicsContext.fillRect(0,0,600,400);
    }
}
