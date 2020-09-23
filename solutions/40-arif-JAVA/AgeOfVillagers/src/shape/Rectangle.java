package shape;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;

public class Rectangle implements IShape {
    GraphicsContext graphicsContext;
    public Rectangle(GraphicsContext graphicsContext) {
        this.graphicsContext = graphicsContext;
    }

    @Override
    public void draw() {

        graphicsContext.fillRect(20,20,20,20);

    }
}
