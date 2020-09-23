package shape;

import javafx.scene.canvas.GraphicsContext;

public class Line implements IShape {
    GraphicsContext graphicsContext;
    double x1,x2, y1,y2;
    public Line(GraphicsContext graphicsContext, double x1, double y1, double x2, double y2) {
        this.graphicsContext =graphicsContext;
        this.x1 =x1;
        this.x2 = x2;
        this.y1 = y1;
        this.y2 = y2;
    }

    @Override
    public void draw() {
        this.graphicsContext.strokeLine(x1,y1, x2,y2);
    }
}
